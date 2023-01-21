// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Fillmatr(matrix);
Console.WriteLine();
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);
int sumOfRow = SumOfRowElem(matrix, 0);
int minRow = 0;

void Fillmatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfRowElem(int[,] matr, int i)                                    // Метод нахождения суммы элементов строки
{
    int sumOfRow = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sumOfRow = sumOfRow + matr[i, j];
    }
    return sumOfRow;
}

for (int i = 1; i < matrix.GetLength(0); i++)                           // Находим строку с минимальной суммой элементов
{
    int tempRow = SumOfRowElem(matrix, i);
    if (sumOfRow > tempRow)
    {
        sumOfRow = tempRow;
        minRow = i;
    }
}

Console.WriteLine();
Console.WriteLine($"{minRow + 1} строка");


