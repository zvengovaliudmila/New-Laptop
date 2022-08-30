// See https://aka.ms/new-console-template for more information

string? input = Console.ReadLine();

bool ValidateInput(string input)
{
    bool isNumber = int.TryParse(input, out int number);

    if(!isNumber)
    {
       return false;
    }
    if (input.Length < 3)
    {
        return false;
    }
    return true;
}
char GetThirdNumber(string number)
{
    return number[2];
}

bool isValid = ValidateInput(input);

if(!isValid)
{
Console.WriteLine("No Valid number");
return;
}

char result = GetThirdNumber(input);

Console.WriteLine(result);