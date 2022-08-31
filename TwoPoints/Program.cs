/*Программа,которая принимает на вход координаты двух точек и находит расстояние между ними
в 3D пространстве. A(3,6,8); В(2,1,-7) -> 15,84  и A(7,-5,0); B(1,-1,9)-> 11,53*/

Console.WriteLine("Введите координату х первой точки: ");
bool isNumberX1 = int.TryParse(Console.ReadLine(),out int x1);               //вв.данных и проверка на цифр.ввод

Console.WriteLine("Введите координату y первой точки: ");
bool isNumberY1 = int.TryParse(Console.ReadLine(),out int y1);

Console.WriteLine("Введите координату z первой точки: ");
bool isNumberZ1 = int.TryParse(Console.ReadLine(),out int z1);

Console.WriteLine("Введите координату х второй точки: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(),out int x2);

Console.WriteLine("Введите координату y второй точки: ");
bool isNumberY2 = int.TryParse(Console.ReadLine(),out int y2);

Console.WriteLine("Введите координату z второй точки: ");
bool isNumberZ2 = int.TryParse(Console.ReadLine(),out int z2);

if(!isNumberX1 || !isNumberX2 || !isNumberY1 || !isNumberY2 || !isNumberZ1 || !isNumberZ2 )
{
   Console.WriteLine("Числа введены неверно");
   return;
}

double GetLength(int x1, int y1, int z1, int x2, int y2, int z2 )          //метод получения длины отрезка в3D
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2) + Math.Pow ((z2-z1), 2));
}
Console.WriteLine($"расстояние: {GetLength(x1, y1, z1, x2, y2, z2)}");