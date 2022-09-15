/*Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
7 -> 0 , 2
5 -> 1 , 0
18 -> нет такого элемента*/


void FindIndex( int[,] table)
{
      Console.WriteLine("Введите число: ");
      bool isNumber = int.TryParse(Console.ReadLine(), out int f);

      if(!isNumber)
      {
         Console.WriteLine("Неправильный ввод. Введите число!");
  
       }
       for( int i = 0; i < table.GetLength(0); i++ )
       {
           for( int j = 0; j < table.GetLength(1); j++)
           {
              if (table[i, j]==f)
              {
                  Console.WriteLine($" Число {f} в двумерном массиве имеет индексы({i};{j})");
              }
              else
              {
              Console.WriteLine($"Индексов числа {f} не найдено .");   
              }
           }
       }
}
int[,] CreateRandomMassive  (int[,]table)
{
    for(int i = 0; i < table.GetLength(0); i++)
    {
      for(int j = 0; j < table.GetLength(1); j++)
      {
          table[i, j] = new Random(). Next(1,10);

      }
    }
    return table;
}


void PrintMassive(int[,] table)
{
    for( int i = 0; i < table.GetLength(0); i++)
    {
      for ( int j = 0; j < table.GetLength(1); j++)
      {
        Console.Write($"|{table[i, j]}|");
      }
      Console.WriteLine();

    }
}

int[,] result = new int[2, 2];
int [,] res = CreateRandomMassive(result);
FindIndex(res);
PrintMassive(res);










