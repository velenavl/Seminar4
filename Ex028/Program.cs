// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. 
Console.WriteLine("Введите число N: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber)
{
    Console.WriteLine("Не число");
    return;
}

int GetPrNumber(int number)
{
    if(number < 1)
    {
        return 0;
    }
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine(GetPrNumber(n));