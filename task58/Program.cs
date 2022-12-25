// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int x = InputNumbers("Введите число строк 1-й матрицы: ");
int y = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int z = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до 9: ");

int[,] firstMartrix = new int[x, y];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[y, z];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[x,z];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int w = 0; w < firstMartrix.GetLength(1); w++)
      {
        sum += firstMartrix[i,w] * secondMartrix[w,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}



// ALEX Shah 2022.