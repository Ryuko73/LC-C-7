void PrintArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(numbers[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
void Zadacha1()
{
    Console.WriteLine("Ввелите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввелите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    Console.WriteLine($"Массив размера {rows} {columns}");
    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

}
void FillArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.NextDouble() * 50;
        }
    }
}
//Zadacha1();
//Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
void Zadacha2()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    Console.WriteLine($"Массив размера {-1 + rows} {-1 + columns}");
    int[,] numbers = new int[rows, columns];
    FillArray2(numbers);
    PrintArray2(numbers);
    FindIndex(numbers, rows, columns);
}
void FillArray2(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 11);
        }
    }
}
void PrintArray2(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
void FindIndex(int[,] numbers, int rows, int columns)
{
    Console.WriteLine("Введите индекс в строке");
    int First = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс в столбце");
    int Second = Convert.ToInt32(Console.ReadLine());
    if (First <= columns && Second <= rows)
    {
        Console.WriteLine(numbers[First, Second]);
    }
    else
    {
        Console.WriteLine("Нет такого элемента");
    }
}
//Zadacha2();
//адайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
void Zadacha46()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows} {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray3(numbers);
    PrintArray3(numbers);
    FindProizvedenie(numbers,rows,columns);
}
void FillArray3(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 11);
        }
    }
}
void PrintArray3(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
void FindProizvedenie(int[,] numbers, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        int a = 0;
        int b = 0;
        for (int t = 0; t < rows; t++)
        {
            a += numbers[t, i];
            b += (numbers[t, i] % 2 == 0) ? 1 : 0;
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)a/rows}");
    }
}
Zadacha46();