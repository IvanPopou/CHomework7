//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Ряд > 1
//Колонка > 7
//1, 7 -> такого числа в массиве нет

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

bool ElementValidation(int[,] matrix, int row, int col)
{
    if(row > matrix.GetLength(0) || col > matrix.GetLength(1))
    {
        System.Console.WriteLine($"Строка {row}, столбец {col} -> такого числа в массиве нет");
        return false;
    }
    return true;
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

int[,] Matrix = GenerateMatrix();
PrintMatrix(Matrix);

int Row = Prompt("Введите номер строки");
int Col = Prompt("Введите номер столбца");
if(ElementValidation(Matrix, Row, Col))
{
    int element = Matrix[Row-1, Col-1];
    System.Console.WriteLine($"Значение указанного элемента {element}");
}