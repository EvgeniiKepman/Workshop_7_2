// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1
// 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Введите строку элемента массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ряд элемента массива: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[6,6];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,9);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

if (m < 0 & m > matrix.GetLength(0) - 1 & n < 0 & n > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента массива - {matrix[m, n]}");
}
