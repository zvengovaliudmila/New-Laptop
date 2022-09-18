/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/


void Recursive (int m, int n, int i = 0)
{
     if(i==n)
     {
        return;
     }

    Console.Write($"{m}, ");
    Console.WriteLine();
    Recursive (++m,n, ++i);
}


Recursive(4, 8);

