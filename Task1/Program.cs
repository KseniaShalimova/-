bool Check(string input)
{
    if (input == "q")
    {
        return true;
    }
    int value = Convert.ToInt32(input);
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}


bool EndorNot = true;
while (EndorNot == true)
{
    Console.WriteLine("Введите число ");
    string input = Console.ReadLine();
    bool check = Check(input);
    if (check == true)
    {
        EndorNot = false;
    }
}