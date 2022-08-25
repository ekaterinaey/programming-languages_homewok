// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/

 int[] array = new int[7];

 int[] FillArray(int[] arr)
 {
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
 }

 void PrintArray(int[] arr)
 {
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
 }

 int FindEvenNumbers(int[] arr)
 {
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
 }


int[] result = FillArray(array);
PrintArray(result);
Console.WriteLine();
int evenNumbers = FindEvenNumbers(result);
Console.WriteLine(evenNumbers);


/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/

 int[] arraySecond = new int[4];

 int[] FillArraySecond(int[] arr)
 {
    Random randomSecond = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomSecond.Next(0, 100);
    }
    return arr;
 }

 void PrintArraySecond(int[] arr)
 {
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
 }


 int FindSumNumbers(int[] arr)
 {
    int sum = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        if(i%2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
 }

int[] resultSecond = FillArraySecond(arraySecond);
PrintArraySecond(resultSecond);
Console.WriteLine();
int sumNumbers = FindSumNumbers(resultSecond);
Console.WriteLine(sumNumbers);

 /*Задача 38: Задайте массив вещественных чисел.
  Найдите разницу между максимальным и минимальным элементов массива.*/

Console.WriteLine("Введите числа");
double[] arrayNumbers = new double[4];

double[] FillArrayNumbers(double[] arr)
{
    for(int i = 0; i < arr.Length; i++){
        arr[i] = double.Parse(Console.ReadLine());
      
    }
    return arr;
}
  
void PrintArrayNumbers(double[] arr)
{
    for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}
}

double FindMaxNumber(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMinNumber(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}


double[] resultNumbers = FillArrayNumbers(arrayNumbers);
PrintArrayNumbers(resultNumbers);
Console.WriteLine();
double resultMax = FindMaxNumber(resultNumbers);
Console.WriteLine($"Максимальное число: {resultMax}");
Console.WriteLine();
double resultMin = FindMinNumber(resultNumbers);
Console.WriteLine($"Минимальное число: {resultMin}");
double difference = resultMax - resultMin;
Console.WriteLine($"Разница между максимальным и минимальным чилом:  {difference}");


