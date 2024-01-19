int[] ArrayReversal(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int number1 = arr[i];
        arr[i] = arr[arr.Length - (i + 1)];
        arr[arr.Length - (i + 1)] = number1;
    }
    return arr;
}



int[] arr = { 1, 2, 3, 4, 5, 6 };
int[] reversArr = ArrayReversal(arr);
foreach (int e in reversArr)
{
    Console.Write($"{e} ");
}