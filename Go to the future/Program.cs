﻿void FillArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.WriteLine("Введите слово или цифры: ");
        A[i] = Console.ReadLine();
    }
}

void Choise(string[] A)
{
    string B = String.Empty;
    for (int i = 0; i < A.Length; i++)
    {
        string Z = A[i];
        char[] a = Z.ToCharArray();
        if(a.Length < 4)
        {
            B = B + A[i] + " ";
        }

    }
    Console.WriteLine(B);
}

string[] A = new string[4];
FillArray(A);
Choise(A);