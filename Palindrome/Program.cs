/*Программа,которая принимает на вход пятизначное число и
 проверяет, является ли оно палиндромом*/

 Console.WriteLine("Введите пятизначное число: ");
 bool isNumber = int.TryParse(Console.ReadLine(),out int number);//ввод данных в number и проверка

if (isNumber != true)                                            //проверка ввода на символы!цифры
{
    Console.WriteLine("Некорректный ввод.");                    //стоп программа из-за ввода букв
    return;
}
bool CheckPolindrome(int number)                                //проверка на зеркальность 5зн.числа
{
     string text = number.ToString();                           //для работы число переводим в текст
     if(text.Length > 5 || text.Length < 5)                    //проверка длины 5 цифр
     {
        Console.WriteLine("Некорректная длина данных.");
        return false;
     }
     if(text[0] == text[4] && text[1] == text[3])
     {
        return true;
     }

      return false;

}

bool check = CheckPolindrome(number);                           //вывод метода 
Console.WriteLine(check);                                       //вывод результата