// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }

}

Console.Clear();
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Введите позицию элемента через пробел: ");
int[] pos = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(matrix[pos[0], pos[1]]);
