int[] CompleteArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int EvenCountCheck(int[] numbers)
{
    int count = 0;
    foreach (int e in numbers)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



int[] arr = new int[10];
int[] numbers = CompleteArray(arr);
int count = EvenCountCheck(numbers);
Console.WriteLine();
Console.WriteLine(count);