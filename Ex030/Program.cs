// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// void PrintSqares(int[] sqares)
// {
//     int i = 0;
//     int Len = sqares.Length;
//     while (i < Len)
//     {
//         Console.WriteLine(sqares[i]);
//         i++;
//     }
// }

// int[] GenrArrey(int N)
// {
//     int[] arr = new int[N];
//     Random random = new Random();
//     int number = random.Next(0, 2);
//     for (int i = 0; i < N; i++)
//     {
//        arr[i] = random.Next(0, 2); 
//     }
//     return arr;
// }

// PrintSqares(GenrArrey(8));

int[] FillArray(int n)
{
    Random random=new Random();
    int[] newArray = new int [n];
    for (int i=0;i<n; i++)
    {
    newArray[i]=random.Next(0, 2);    
    }
    return newArray;
}

void PrintArr(int[] array)
{
    for (int i=0; i<array.Length;i++)   
    {
    Console.Write($"{array[i]}");    
    }
}

Console.WriteLine("Введите размер массива number");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (isNumber==false || number<1)
{
    Console.WriteLine("Неверный ввод");
    return;
}
PrintArr(FillArray(number));