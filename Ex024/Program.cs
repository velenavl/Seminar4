// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(isNumber == false)
{
    Console.WriteLine("Is not valid");
    return;
}

int result = GetSumNumber(number);
Console.WriteLine(result);


int GetSumNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum+=i;
    }

    return sum;
}