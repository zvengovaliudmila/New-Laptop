#nullable disable

/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 2*/

int[] FillArray(int length)
{
    Random random = new Random();
    int[] inputArray = new int[length];
    
    for(int i = 0; i < length; i++)
    {
        inputArray[i] = random.Next(100, 1000);
        
    }
    return inputArray;
}   

int GetFindNumber(int[]array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if(array[i]%2 == 0)
        {
              count++;
        }
    }
    return count;
}
void PrintArr(int[]array)
{
   if(array.Length == 0)
   {
    Console.WriteLine("Что-то пошло не так!");
    return;
   }
   Console.Write("[");
   
    for(int i = 0; i < array.Length-1; i++)
    {
      Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
Console.WriteLine("Введите размер массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if(isNumber == false || length < 1 )
{
   Console.WriteLine("Неправильный ввод!");
}

PrintArr(FillArray(length));
  
int[]array = FillArray(length);
int count = GetFindNumber(array);
Console.WriteLine($"Чётных чисел в массиве: {count};");




