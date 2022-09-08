//Принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой
//длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 2 др.сторон

Console.WriteLine("Введите первое число");
int NumberX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int NumberY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int NumberZ = Convert.ToInt32(Console.ReadLine());

bool resultThreeAngle = isThreeAngle(NumberX, NumberY, NumberZ);

if(resultThreeAngle == false)
{

    Console.WriteLine("Неверные параметры!");
}
else 
{

    Console.WriteLine("Треугольник может существовать");
}


bool isThreeAngle(int x, int y, int z)
{
     if (x <= 0 || y <= 0 || z <= 0 )
     {
        return false;
     }
     if ((x + y) > z && (x + z) > y && ( y + z) > x)
     {
        return true;
     }
     return false;
}


