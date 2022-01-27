void FillArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.WriteLine("Введите слово или цифры: ");
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

void Choise(string[] A, string[] B)
{
    int o = 0;
    for (int i = 0; i < A.Length; i++)
    {
        string Z = A[i];
        char[] a = Z.ToCharArray();
        if(a.Length < 4)
        {
            B[o] = Z;
            o++;
        }
    }
}
string[] A = new string[4];
string[] B = new string[4];
FillArray(A);
PrintArray(A);
Choise(A, B);
PrintArray(B);