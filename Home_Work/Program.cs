// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве
void Zadacha_34()
{
    Random random = new Random();
    int size = random.Next(5, 12);
    int[] array = new int[size];
    FillArray(array, 100, 1000);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count ++;  
    }
    Console.WriteLine("Количество четных элементов массива равно " + count);
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha_36()
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int Sum = 0;
    
    for (int i = 0; i < size; i+=2)
    {
        Sum = Sum + array[i];  
    }
    Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях, равна " + Sum);
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива
void Zadacha_38()
{    
    double[] array = new double[8];
    double Max = array[0];
    double Min = array[0];
    FillArray1(array);
    Console.WriteLine("Заданный массив ");
    PrintArray1(array);
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max) Max = array[i];
    }
    Console.WriteLine("Максимальный элемент массива равен " + Math.Round(Max, 2));
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < Min) Min = array[i];
    }
    Console.WriteLine("Минимальный элемент массива равен " + Math.Round(Min, 2));    
    Console.WriteLine("Разность между максимальным и минимальным элементами массива составляет " + Math.Round((Max - Min), 2));
}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void FillArray1(double[] array) // для переменной double
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++) 
    array[i] = random.Next(-1000, 1000) + random.NextDouble();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArray1(double[] array)    // для переменной double
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(Math.Round(array[i], 2) + " ");
    }
    Console.WriteLine();
}

// Zadacha_34();
// Zadacha_36();
Zadacha_38();

