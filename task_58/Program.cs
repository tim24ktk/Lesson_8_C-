/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
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

// метод получения результата произведения 2-х матриц 
int[,] GetMatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(1), secondMatrix.GetLength(0)];

    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                int sum = 0;

                for (int k = 0; k < secondMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                result[i, j] = sum;
            }
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

// проверка работы методов
int m = GetNumber("Введите колчичество строк матрицы А: ");
int n = GetNumber("Введите колчичество столбцов матрицы А: ");
int[,] matrixA = InitMatrix(m, n);

Console.WriteLine("Матрица А:");
PrintMatrix(matrixA);
Console.WriteLine();

int h = GetNumber("Введите колчичество строк матрицы В: ");
int d = GetNumber("Введите колчичество столбцов матрицы В: ");
int[,] matrixB = InitMatrix(h, d);

Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);
Console.WriteLine();

int[,] matrixC = GetMatrixProduct(matrixA, matrixB);
Console.WriteLine("Матрица C:");
PrintMatrix(matrixC);
