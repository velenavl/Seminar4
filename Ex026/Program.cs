// Напишите программу, которая принимает на вход число и выдает количество цифр в нем.
Console.WriteLine("Введите число N: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);

if(!isNumber)
{
    Console.WriteLine("Не число");
    return;
}

int GetLenNumber(int number)
{
    int count = 0;
    if(number == 0)
    {
        return 1;
    }
    while(number != 0)
    {
        count++;
        number = number / 10;
    }
    
    return count;
}
int result = GetLenNumber(N);
Console.WriteLine(result);