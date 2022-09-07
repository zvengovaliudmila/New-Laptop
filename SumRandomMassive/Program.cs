#nullable disable
/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19   
[-4, -6, 89, 6] -> 0*/

int[] FillArray (int length)
{
    int[] newArray = new int[length];
    Random random = new Random();

    for( int i = 0; i < length; i++)
    {
        newArray[i] = random.Next(1, 10);
    }
    return newArray;
}
int GetSumNumbers(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
     if(array[i]%2 == 1 )
     {
          sum += array[i]; 
     }
    }
    return sum;
}
void PrintArray( int[]array)
{
    if(array.Length == 0)
    {
    Console.WriteLine("Неверное значение !");
    return;
    }
    Console.Write("[");
     
    for(int i = 0; i < array.Length-1; i++)
    {
      Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}

Console.WriteLine("Ведите размер массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (isNumber == false || length < 1)
{

    Console.WriteLine("Введите заново!");
}

int[] result = FillArray(length);
PrintArray (result); 
int sum = GetSumNumbers(result);
Console.WriteLine($"Сумма нечётных элементов в массиве равна:{sum};");

