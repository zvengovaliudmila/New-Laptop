// Пузырьковая сортировка- сравниваем парами
// На первом этапе заполняем массив - начальный.

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); //число введённое
int[]array = new int[n]; // заводим массив, кладем туда n
for(int i = 0; i < n; i++) // заполняем массив
{
    Console.Write("Введите значение массива:");//приглаш.к вводу
    array[i] = Convert.ToInt32(Console.ReadLine());//заполнили
}
Console.WriteLine("Начальный массив: ["+ string.Join(", " , array) + "]");
Console.WriteLine();
// Далее сортировка. Главный проход. n - количество прохождений по нашему массиву
for(int i =0; i < n; i++) //сначала проходим  i- кол. проходов, а  j - сам проход.
{
    for(int j = 0; j < n-1; j++) // если не будет n-1,будет выпадать за цикл
     //n-1 - у последнего элемента нет пары
    {
        if (array[j] > array[j + 1]) //элемент слева больше элемента справа
        {
           int temp = array[j];   //во времен.переменную кладём эл.слева(больший)
           array[j] = array[j + 1]; //на место эл.,кот.больше, кладём эл.справа(меньший)
           array[j + 1] = temp; // на место эл.(меньшего,справа),кладём эл.больший слева

        }
    }
    Console.WriteLine(i + "[" + string.Join (", ", array) + "]");
}
