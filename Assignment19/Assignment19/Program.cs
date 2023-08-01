using System;
using System.Diagnostics;

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

        SequentialSum(numbers);
        ParallelSum(numbers);

    }
    static long SequentialSum(int[] numbers)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();

        long sum = 0;
        for (int i = 0; i<numbers.Length; i++)
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

        // Calculate the size of each chunk to distribute the work among threads
        int chunkSize = numbers.Length / processors;

        // Create an array to store the partial sums calculated by each thread
        long[] partialSums = new long[processors];

        Thread[] threads = new Thread[processors];


        for (int i = 0; i < processors; i++)
        {
            int threadIndex = i; 
            threads[i] = new Thread(() =>
            {
                long partialSum = 0;

                // Calculate the starting and ending index for this thread's chunk of the array
                int start = threadIndex * chunkSize;
                int end = (threadIndex == processors - 1) ? numbers.Length : (threadIndex + 1) * chunkSize;

                for (int j = start; j < end; j++)
                {
                    partialSum += numbers[j];
                }

                partialSums[threadIndex] = partialSum;
            });

            threads[i].Start();
        }

        for (int i = 0; i < processors; i++)
        {
            threads[i].Join();
        }

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