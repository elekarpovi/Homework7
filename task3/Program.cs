// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int [,] array = new int [m, n];
Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j] = rnd.Next(-10, 10);
        Console.Write(String.Format("{0,6}", array [i, j]));
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое по столбцам: ");
System.Console.WriteLine();

for (int j = 0; j < n; j++)
{
    double sum = 0;
    double avg = 1;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i, j];              
    }

    avg = sum/m;
    Console.Write(String.Format("{0,6}", Math.Round(avg, 2)));
}
    
