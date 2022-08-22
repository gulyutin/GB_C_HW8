//Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m, n];


Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int  j = 0; j < n; j++)
    {
        array[i, j] = rand.Next(1, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("");
}

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\nСтрока №{minSumLine+1} с наименьшей суммой элементов. Сумма элементов в данной строке: {sumLine} ");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
