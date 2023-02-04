// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

double [,] array = new double [m, n];


void FillArray(double [,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((-10 + rnd.NextDouble() * 20), 2);
         
        }
        
    }
}
FillArray(array);

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0,9}", array[i, j]));         
        }
        System.Console.WriteLine();
        
    }


System.Console.WriteLine();
