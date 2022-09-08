#nullable disable
/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/     

Console.WriteLine("Введите количество чисел в массиве: ");
bool isNumber = int.TryParse(Console.ReadLine(),out int length );
if (isNumber == false || length < 1)
{
    Console.WriteLine("Invalid number.");
}
int[]FillArray(int length)
{
      int[]newArray = new int [length];
      Random random = new Random();

      for(int i = 0; i < length; i++)
      {
          newArray[i] = random.Next(1, 20);
      }
      return newArray;
}
int GetMaxNumber (int[] array)
{
      int max = 0;
      for( int i = 0; i < length;  i++)
      {
        if (array[i] > max)
        {
            max = array[i];
        }
      }
      return max;
}
int GetMinNumber (int[] array)
{
      int min = 0;
      for( int i = 0; i < length; i++)
      {
        if (array[i] < min)
        {
            min = array[i];
        }
      }
       return min;
}
void PrintArray( int[] array)
{
     if( array.Length == 0)
     {
         Console.WriteLine("Invalid number");
         return;
     }
     Console.Write("[");
     for ( int i = 0; i < array.Length - 1; i++)
     {
          Console.Write($"{array[i]}, ");
     }
     Console.Write(array[array.Length-1]);
     Console.Write("]");
}
int[]result = FillArray(length);
PrintArray(result);
int getMax = GetMaxNumber(result);
int getMin = GetMinNumber (result);
int getMaxMin = getMax - getMin;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {getMaxMin};");
