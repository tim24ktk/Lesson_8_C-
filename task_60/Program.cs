/*
    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

// метод получения числа от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// метод инициализации двухмерного массива(матрицы)
int[,,] InitMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);
            }
        }
    }

    return matrix;
}

// метод вывода массива в консоль
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

// проверка работы методов
int x = GetNumber("Введите количество строк матрицы X: ");
int y = GetNumber("Введите количество столбцов матрицы Y: ");
int z = GetNumber("Введите количество столбцов матрицы Z: ");
int[,,] matrix = InitMatrix(x, y, z);

Console.WriteLine("Матрица :");
PrintMatrix(matrix);
