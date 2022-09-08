#nullable disable

//Преобразование десятичного числа в двоичное.45 -> 101101, 3 -> 11, 2->10
Console.WriteLine("Введите десятичное число:");
int i = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(i, 2);
Console.WriteLine(" В двоичной системе исчисления это:" +s);

