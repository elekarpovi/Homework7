// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

System.Console.Write("Введите индекс элемента в массиве.");
System.Console.WriteLine();
System.Console.Write("Индекс в строке: ");
int k = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Индекс в столбце: ");
int l = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

if (k < 0 | l < 0 | k > array.GetLength(0)-1 | l > array.GetLength(1)-1) 

Console.Write($"Такого элемента в массиве нет!");


else 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       if (k == i && l == j)
       {
          
          Console.Write($"Такой элемент в массиве есть. Его значение: {array[k, l]}.");
       } 
    }
}





  
 

   
        

 




    
    
                   

    


