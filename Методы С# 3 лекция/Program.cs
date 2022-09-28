
/*void Method1()                      //ничего не принимает и не возвращает
{

   Console.WriteLine("Автор,,,");
}
Method1();*/



/*void Method2(string msg)               //принимает какие-то аргументы и ничего не возвращает
{

   Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");*/


/*void Method21(string msg, int count)    //count - количество сообщений //принимает арг.и не возвр.
{
     int i = 0;
     while(i < count)
     {
       Console.WriteLine(msg);
       i++;

     }

}
Method21(msg:"Текст сообщения",count: 4);        //сколько раз хотим увидеть это сообщение

                                       //При зацикливании программы - Ctrl C*/


/*int Method3()                  //не принимает аргументов и что-то возвращает
{

   return DateTime.Now.Year;        // например, год
}

int year = Method3();
Console.WriteLine(year);*/


/*string Method4(int count, string text)      // метод что-то принимает и что-то возвращает
{                                        // будем компоновать строку некое кол-во(count)раз

    int i = 0;                        //цикл
    string result = String.Empty;      //"" пустая строка; string result -кладем конеч. рез.

   while(i < count)
   {
      result = result + text;
      i++;
   }
   return result;
}   
string res = Method4(10, "asdf");    //текст, который будем склеивать 10 раз
Console.WriteLine(res);*/


/*string Method4(int count, string text)             // c циклом for
{
     string result = String.Empty;
     for(int i = 0; i < count; i++)   // int i=0-инициал.счетчика,i++ инкремент(увелич.счетчика)
     {
        result = result + text;

     }
     return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);*/

//Вывод таблицы умножения на экран ( цикл в цикле)


/*for(int i = 2; i <= 10; i++)        //1 цикл-внешний  ; таблица умножения начинается с 2
{ 
   for(int j = 2; j <= 10; j++)
   {
      Console.WriteLine($"{i} х {j} = {i*j}");          // во 2 цикле укажем произведение
   }
   Console.WriteLine();       //  переход на новую строку раздел будет между блоками
}*/

/*//Задача: В тексте пробелы заменить черточками, мален. буквы"к" заменить большими,"с"-маленькими

string text = "- Я думаю, сказал князь, улыбаясь,- что,"
             + " ежели бы вас послали вместо нашего милого Винценгероде,"
             + " вы бы взяли приступом согласие прусского короля."
             + " вы так красноречивы.Вы дадите мне чаю?";

//string s = "qwerty"
//            012345  обращаемся по индексу

// s[3] // r        - идентификатор строки s, обращаемся к третьему индексу 

string Replace(string text, char oldValue, char newValue)   //newValue - меняем на новую строку
{
    string result = String.Empty;                      // инициализация строки,пустая строка
    int length =  text.Length;      //получить длину нашей строки,text.Length-кол-во символов
    for( int i = 0; i < length; i++) //пробегаемся от 0 символа до конца строки
    {
       if(text[i] == oldValue)result= result + $"{newValue}";   //если текущий индекс совпал с
                                                        //oldValue-символом,кот.хотим заменить
                                            //в result кладем нов. знач. в виде строки newValue
       else result= result + $"{text[i]}";     // если не обнаруж.символов,кот.хотим заменить,
                                      // в result добавляем текущий символ

    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);*/


//Найти позицию минимального элемента в неотсортированной части массива.
// Произвести обмен этого значения со значением первой неотсортированной позиции.
//Повторять до тех пор, пока есть неотсортированные элементы.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 1, 1 };     //массив, который будем отсортировывать  

void PrintArray(int[] array)                 //метод,выводящий массив на экран
{
     int count = array.Length;               //получение количества элементов
     for(int i = 0; i < count; i++)
     {
         Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
}

void SelectionSort(int [] array)           //метод, который будет упорядочивать наш массив
{
    for(int i = 0; i < array.Length - 1; i++)    //
    {
      int minPosition = i;      //запоминаем позицию раб.элемента с кот.мы будем произв.дейст-я

       for( int j = i + 1; j < array.Length; j++ )              //поиск максимального
       {

          if(array[j]< array[minPosition])      //внутренний цикл
          {
              minPosition = j;

          }
       }

      int temporary = array[i];   //поменяем значение минимальной позиции с той,кот.нашли;рабочая позиция
      array[i] = array[minPosition];//'найденный элемент в результате работы кода
      array[minPosition] = temporary; //в минимальную позицию кладем элемент,кот.был временным

    }

}  

PrintArray(array);                               //вывод метода - изначального массива
SelectionSort(array);

PrintArray(array);
