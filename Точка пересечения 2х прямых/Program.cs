#nullable disable
// Найти точку пересечения двух прямых.

Console.WriteLine("Введите точку b1:");
bool isNumberb1  = double.TryParse(Console.ReadLine(), out double b1);

Console.WriteLine("Введите точку k1:");
bool isNumberk1 = double.TryParse(Console.ReadLine(), out double k1);

Console.WriteLine("Введите точку b2:");
bool isNumberb2  = double.TryParse(Console.ReadLine(), out double b2);

Console.WriteLine("Введите точку k2:");
bool isNumberk2 = double.TryParse(Console.ReadLine(), out double k2);

if(!isNumberb1 || !isNumberk1 || !isNumberb2 || !isNumberk2)
{
   Console.WriteLine("Некорректный ввод данных.");
   return;
}

 CrossLines (b1,  k1,  b2,  k2);

 void CrossLines(double b1, double k1, double b2, double k2)
 {
      if((k1==k2) && (b1==b2))
      {
         Console.WriteLine("Прямые совпадают!");
         return;
      }
      if(k1==k2)
      {
          Console.WriteLine("Прямые параллельны!");
          return;
      }

      double x = (b2-b1)/(k1-k2);
      double y = k1*x + b1;
      Console.WriteLine($"Прямые пересекутся в точке с координатами X{x}; и Y{y}; ");
 }






