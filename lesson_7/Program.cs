// See https://aka.ms/new-console-template for more information


/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.*/

 bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
 bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

 if (isNumberM == false || isNumberN == false)
 {
    Console.WriteLine("Вы ввели не правильные данные");
 }


 double[,] result = FillArray2D(m, n);
 PrintArray2D(result);


double[,] FillArray2D(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * 20 - 10),2);
        }

    }
    return array;
}

void PrintArray2D(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}



 /*Задача 52. Задайте двумерный массив из целых чисел. 
 Найдите среднее арифметическое элементов в каждом столбце.*/

 bool isNumberM2 = int.TryParse(Console.ReadLine(), out int m2);
 bool isNumberN2 = int.TryParse(Console.ReadLine(), out int n2);

 if (isNumberM2 == false || isNumberN2 == false)
 {
    Console.WriteLine("Вы ввели не правильные данные");
 }

int[,] FillArray(int m2, int n2)
{
    int[,] array = new int[m2, n2];
    Random random = new Random();

    for(int i = 0; i < m2; i++)
    {
        for(int j = 0; j < n2; j++)
        {
            array[i, j] = random.Next(1, 100);
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] result2 = FillArray(m2, n2);
 PrintArray(result2);


    for(int j = 0; j < result2.GetLength(1); j++)
    {
        double arithmeticAverage = 0;
        for(int i = 0; i < result2.GetLength(0); i++)
        {
            arithmeticAverage += result2[i, j];
        }
        
        Console.Write($"{ arithmeticAverage/ result2.GetLength(0)} ");
        
    }
    


