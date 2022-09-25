// 

void FillArray( int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
          collection[index]=new Random().Next(1, 10);
          index++;
    }
}
void PrintArray(int [] col)
{
     int count = col.Length;        //количество элементов
     int position = 0;             //вместо index
     while(position < count)
     {
        Console.WriteLine(col[position]);
        position++;
    
     }
}

int[] array = new int[10];         //задали массив из каких-то 10 элементов


int IndexOf(int[]collection, int find)
{

       int count = collection.Length;
       int index = 0;                          
       int position = 0;              // если элемента нет(например,444 ), пишем -1
       while(index < count)
       {
            if(collection[index]==find)
            {
                position = index;
                break;                     //ставим ,если хотим,чтоб 4 была первой?Не получилось
            }
            index++;
       }
       return position;   // после отработки предыдущих действий
}

FillArray(array);
array[4] = 4;    // добавляем приудительно,чтоб было больше 4-к
array[6] = 4;
PrintArray(array);
Console.WriteLine();   // Чтоб убедиться , что не вывод массива -выводим первой 4-ку

int pos=IndexOf(array, 4);  //в int pos кладем результат работы IndexOf,аргумент-массив,ищем 4
Console.WriteLine(pos);    // в консоли после массива будет стоять индекс 4-ки



