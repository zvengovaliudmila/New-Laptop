// 

int[] array = new int[10];



void FillArray ( int[]collection)
{
       int length = collection.Length;
       int index = 0;
       while( index < length)
       {
             collection[index] = new Random().Next(1,10);
             index++;
       }
}
void PrintArray(int[] col)
{
       int count = col.Length;         // количество элементов.
       int position = 0;               // вместо index
       while(position < count)
       {
          Console.WriteLine(col[position]);        // значение текущего элемента
          position++;                              // увеличиваем значение текущей позиции
       }
}

FillArray(array);
PrintArray(array);
