// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
int[,] CreateMatrixFirst(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int x = new Random().Next(10, 100);
            matrix[i, j] = x;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
int[,] CreateMatrixSecond(int n, int m)
{
    int[,] matrix2 = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int x = new Random().Next(10, 100);
            matrix2[i, j] = x;
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix2;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMultiply(int[,] matrix, int[,] matrix2)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
    return result;
}
PrintMatrix(MatrixMultiply(CreateMatrixFirst(4,4),CreateMatrixSecond(4,4)));