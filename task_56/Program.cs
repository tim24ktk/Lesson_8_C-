/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// метод получения числа от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// метод инициализации двухмерного массива(матрицы)
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

// метод получения номера строки с наименьшей суммой элементов
void NumberOfString(int[,] matrix)
{
    int minSum = 0;
    int indexOfString = 0;

    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        minSum += matrix[0, k];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            indexOfString = i;
        }

        sum = 0;
    }

    Console.WriteLine($"{indexOfString + 1} строка");
}

// метод вывода массива в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// проверка работы методов
int m = GetNumber("Введите колчичество строк двумерного массива: ");
int n = GetNumber("Введите колчичество столбцов двумерного массива: ");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
NumberOfString(matrix);