using System;
using System.Diagnostics;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[10_000_000];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100000);
        }

        long sequentialSum = SequentialSum(numbers);
        long parallelSum = ParallelSum(numbers);

        Console.WriteLine("Sequential Sum: " + sequentialSum);
        Console.WriteLine("Parallel Sum: " + parallelSum);
    }

    static long SequentialSum(int[] numbers)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();

        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
            sum += numbers[i];

        sw.Stop();
        Console.WriteLine("Time Spent on sequential Calculation: " + sw.ElapsedMilliseconds);
        return sum;
    }

    static long ParallelSum(int[] numbers)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();

        // Get the number of logical processors in the system
        int processors = Environment.ProcessorCount;

        // Calculate the size of each chunk to distribute the work among tasks
        int chunkSize = numbers.Length / processors;

        // Create an array to store the partial sums calculated by each task
        long[] partialSums = new long[processors];

        Task[] tasks = new Task[processors];

        for (int i = 0; i < processors; i++)
        {
            int threadIndex = i;
            tasks[i] = Task.Factory.StartNew(() =>
            {
                long partialSum = 0;

                // Calculate the starting and ending index for this task's chunk of the array
                int start = threadIndex * chunkSize;
                int end = (threadIndex == processors - 1) ? numbers.Length : (threadIndex + 1) * chunkSize;

                for (int j = start; j < end; j++)
                {
                    partialSum += numbers[j];
                }

                partialSums[threadIndex] = partialSum;
            });
        }

        Task.WhenAll(tasks).Wait();

        long sum = 0;
        for (int i = 0; i < processors; i++)
        {
            sum += partialSums[i];
        }

        sw.Stop();
        Console.WriteLine("Time Spent on parallel Calculation: " + sw.ElapsedMilliseconds);
        return sum;
    }
}
