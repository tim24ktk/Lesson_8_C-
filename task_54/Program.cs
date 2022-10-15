/*
    Задача 54: Задайте двумерный массив.
    Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
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

// метод упорядочивания по убыванию элементов каждой строки двумерного массива
int[,] SortRowsByDescending(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

        }
    }

    return result;
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

int m = GetNumber("Введите колчичество строк двумерного массива: ");
int n = GetNumber("Введите колчичество столбцов двумерного массива: ");
int[,] matrix = InitMatrix(m, n);
int[,] newMatrix = SortRowsByDescending(matrix);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);