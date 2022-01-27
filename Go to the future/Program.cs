void FillArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.WriteLine("Введите что нибудь: ");
        A[i] = Console.ReadLine();
    }
}
void PrintArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}