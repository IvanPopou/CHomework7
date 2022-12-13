//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix()
{
    int Rows = Prompt("Введите количество строк в матрице");
    int Columns = Prompt("Введите количество столбцов в матрице");
    int min = Prompt("Введите минимальный порог случайных значений");
    int max = Prompt("Введите максимальный порог случайных значений");
    int[,] matrix = new int[Rows, Columns];
    
    for(int i = 0; i < Rows; i++)
    {
        for(int j = 0; j < Columns; j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

double[] FindEachColumnAverage(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    int summ = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            summ = summ + matrix[j,i];
        }
        average[i] = (double)summ/matrix.GetLength(0);
        summ = 0;
    }

    return average;
}

void PrintMatrix(int[,] matrix)
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

void PrintArray(double[] array, string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{message}{i+1} = {array[i]}");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] array = GenerateMatrix();
double[] ColAverage = FindEachColumnAverage(array);
PrintMatrix(array);
PrintArray(ColAverage, "Среднее арифметическое столбца №");