void PrintSqueares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSqueares(5);
PrintSqueares(10);
PrintSqueares(15);