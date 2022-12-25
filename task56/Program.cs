// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 3 7 2
// 4 9 2 3
// 8 4 3 4
// 5 2 6 8

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] CreateMatrix (int liner, int column, int min, int max) 
{
    int[,] matrix = new int[liner, column];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}

static void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string linestart = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        linestart += matrix[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
}

int[,] array2D2 = CreateMatrix(4, 4, 0, 9);  // строки, столбцы, от 0 до 9 числа.
PrintMatrix(array2D2);
SumStringMatrix(array2D2);