//Каждое последующее число - это сумма двух предыдущих.




int[] GetFib(int N)
{
    int[] result = new int[N];
    result[0] = 0;
    if(N < 2)
    {
    return result;

    }
    result[1] = 1;
    for(int i = 2; i < N; i++ )
    {
        result[i] = result[i-1] +  result[i-2];

    }
    return result;
}

void PrintArray (int[]array)
{
     if ( array.Length== 0)
     {
         Console.WriteLine( "Что-то пошло не так");
         return;
    }
    Console.Write("[");

     for(int i = 0; i < array.Length - 1; i++)
     {
          Console.Write($"{array[i]},");
     }
     Console.Write(array[array.Length -1]);
     Console.Write("]");
}



Console.WriteLine("Enter length: ");
bool isNumber= int.TryParse(Console.ReadLine(), out int length);

if(!isNumber || length <= 0)
{
   Console.WriteLine("Invalid number");
   return;
}


int [] result = GetFib(length);
PrintArray(result);