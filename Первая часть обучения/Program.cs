﻿/*Написать программу,которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна трем символам.Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.При решении не рекомендуется пользоваться
коллекциями,лучше обойтись исключительно массивами.*/

string[] Words = new string [4]{"Yes", "No", "Always", "Never"};
string[] Words1 = new string (Words.Length);



void stringSize(string[] Words, string[] Words1)
{
     int count = 0;   
     for(int i = 0; i < Words.Length; i++ )
     {
       if(Words[i].Length <= 3)
       {
         Words1[count] = Words[i];
         count++;
       }
     }
}
