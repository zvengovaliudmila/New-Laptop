//Программа, которая принимает на вход число и выдаёт сумму цифр в числе:452->11,82->10,9012->12
Console.WriteLine("Введите число: ");

bool isNumber=int.TryParse(Console.ReadLine(), out int number);

if(isNumber==false)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int result = GetSumNumber(number);
Console.WriteLine("Сумма цифр в числе равна: "+result+"");

int GetSumNumber(int number)
{
    int sum = 0;
    while (number!=0)
    {
        sum = sum + number%10;
        number=number/10;
    }
    return sum;
}



