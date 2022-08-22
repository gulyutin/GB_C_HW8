// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.

Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());
int [,] MatrixOne = new int[m, n];
int [,] MatrixTwo = new int[m, n];

Console.WriteLine("");
Console.WriteLine("Первая матрица:");
for (int i = 0; i < m; i++)
{
    for (int  j = 0; j < n; j++)
    {
        MatrixOne[i, j] = new Random().Next(1, 100);
        Console.Write(MatrixOne[i, j] + "\t");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("Вторая матрица:");
for (int i = 0; i < m; i++)
{
    for (int  j = 0; j < n; j++)
    {
        MatrixTwo[i, j] = new Random().Next(1, 100);
        Console.Write(MatrixTwo[i, j] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
Console.WriteLine("Произведение двух матриц:");

int[,] MatrixNew = new int[m, n];
for (int i = 0; i < m(0); i++)
{
    for (int j = 0; j < n(1); j++)
    {
        for (int k = 0; k < m(1); k++)
        {
            MatrixNew[i, j] += MatrixOne[i,k] * MatrixTwo[k,j];
        }
        }
}
Console.WriteLine("");


