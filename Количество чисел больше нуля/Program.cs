#nullable disable


// Пользователь вводит с клавиатуры М чисел.Сколько чисел больше нуля ввел пользователь.
// 0, 7, 8, -2, -2 ==> 2      1,-7,567,89,223 ==>


Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if(!isNumber || length <=0)
{
   Console.WriteLine("Данные введены неправильно.");
   return;
}

GetArray(length);

void GetArray( int length)
{

     int[]num = new int[length];
     int i = 0;
     int count = 0;
     while(i < length)
     {
         Console.WriteLine($"Введите{i + 1}число массива");
         num[i] = Convert.ToInt32(Console.ReadLine());
         if(num[i] > 0 ) count=count+1;
         i++;
         
     }
     
     Console.Write("Введен массив:");
     Console.Write("[");
     for(i=0; i < length; i= i+1)
         Console.Write($" {num[i]}");
   
     Console.Write("]");
     Console.WriteLine();
     Console.WriteLine($"Количество чисел больше нуля:{count}");

}

