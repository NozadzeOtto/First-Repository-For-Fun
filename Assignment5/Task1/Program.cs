int[] array = new int[5] {3,-55555,4,4,5,};
int index = 1;
Console.WriteLine(arrayIndexItemSum(array, index));

// sums number's items
int arrayIndexItemSum(int[] arr, int index)
{
    int sumedValue = 0;
    //tempVariable = Math.Abs(arr[index]);
    int tempVariable = arr[index];
    if (tempVariable < 0) tempVariable *= -1;
    
    int divide = 1;
    for (int i = 1; i < getLength(tempVariable); i++){
        divide *= 10;
    }
    //Console.WriteLine($"divide  =  {divide}");

    // sum items
    while (divide > 0)
    {
        sumedValue += tempVariable / divide;
        tempVariable %= divide;
        divide /= 10;
    }
    return sumedValue;
}

// gets Length of the number : 000 -> 3
int getLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 10;
        //Console.WriteLine(number);
        length++;
    }
    return length;
}