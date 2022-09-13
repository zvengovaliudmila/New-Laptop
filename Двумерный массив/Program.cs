#nullable disable

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.     0,5 7 -2 -0,2      1 -3,3 8 -9,9       8 7,8 -7,1 9

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,]array = new double[m, n];
RandomDoubleArray(m, n);
PrintArray(array);

void PrintArray (double [,] array)
{
    for( int i = 0;  i < array.GetLength(0); i++)
    {
        for(int j = 0;  j < array.GetLength(1); j++ )
        {
        Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();                    //перенос строки
    }
}
void RandomDoubleArray( int m, int n)
{
  Random random = new Random();

       for(int i = 0; i < array.GetLength(0); i++ )             // строки  0
       {
           for(int j = 0; j < array.GetLength(1); j++)           //  столбцы 1
           {
               array[i,j] =  Convert.ToDouble(random.Next(-100, 100))/10;
           }

       }             
}