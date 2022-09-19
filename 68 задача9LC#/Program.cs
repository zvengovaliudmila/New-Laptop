﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9*/


int AkRec( int m, int n)
{
  if( m==0)
     return n + 1;
  else
    if ((m!=0) && (n == 0))
     return AkRec(m-1, 1);
    else
     return AkRec(m-1, AkRec(m, n - 1));

}
Console.WriteLine(AkRec(2, 3));