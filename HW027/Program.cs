// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber)
{
    Console.WriteLine("Не число");
    return;
}

int GetSumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
    return result;
}

Console.WriteLine(GetSumNumber(n));
