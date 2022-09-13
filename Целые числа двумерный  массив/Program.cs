// 48 задача. задайте двумерный массив размером m на n, заполненный случайными целыит числами.


int[,]result = CreateRandomArray (5,6);
PrintArray(result);



void PrintArray (int[,]array)
{
     for( int i = 0; i < array.GetLength(0); i++ )
     {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");

        }
        Console.WriteLine();
     }

}

int[,] CreateRandomArray ( int m, int n)
{
   int[,]array = new int[m, n];
   Random random = new Random();
   for(int i = 0;i < array.GetLength(0); i++)
   {
       for(int j = 0; j < array.GetLength(1); j++)
       {
           array[i,j] = random.Next(0,100);

       }

   }
    return array;
}  