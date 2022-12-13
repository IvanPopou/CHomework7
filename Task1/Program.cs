//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double PromptDouble(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToDouble(Console.ReadLine());
}

double[,] GenerateMatrix()
{
    int Rows = PromptInt("Введите количество строк в матрице");
    int Columns = PromptInt("Введите количество столбцов в матрице");
    double min = PromptDouble("Введите минимальный порог случайных значений");
    double max = PromptDouble("Введите максимальный порог случайных значений");
    double[,] matrix = new double[Rows, Columns];
    
    for(int i = 0; i < Rows; i++)
    {
        for(int j = 0; j < Columns; j++)
        {
            matrix[i,j] = min + new Random().NextDouble()*(max-min);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

double[,] randomArray = GenerateMatrix();
PrintMatrix(randomArray);