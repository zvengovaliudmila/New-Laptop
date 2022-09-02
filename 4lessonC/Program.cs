double a;
double b;
double result;

Console.WriteLine("Пожалуйста, введите число,которое вы хотите возвести в степень: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Спасибо,теперь введите степень, в которую хотите возвести число "+a+"");
b = Convert.ToDouble(Console.ReadLine());
result = Math.Pow(a, b);

Console.WriteLine("Получилось! "+a+" в степени "+b+" равно "+result+"!" );
