// See https://aka.ms/new-console-template for more information


/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());

int[] arrayM = new int[m];

void EnterNumbers(int mNumbers)
{
    for(int i = 0; i < mNumbers; i++)
    {
        Console.WriteLine("Введите число");
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
    }
}

EnterNumbers(m);

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int result = CountPositiveNumbers(arrayM);
Console.WriteLine($"Количество чисел больше 0 - {result}");


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.*/


Console.WriteLine("Введите коодинаты для первой прямой");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коодинаты для второй прямой");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

double FindPointX(double numberK1, double numberB1, double numberK2, double numberB2)
{
    double x = (numberB2 - numberB1) / (numberK1 - numberK2);
    return x;
}

double FindPointY(double numberK1, double numberB1, double numberK2, double numberB2)
{
    double y = (numberK1 * ((numberB2 - numberB1) / (numberK1 - numberK2))) + numberB1;
    return y;
}


double resultPointX = FindPointX(k1, b1, k2, b2);
double resultPointY = FindPointY(k1, b1, k2, b2);
Console.WriteLine($"Коордитната точки пересечения ({resultPointX};{resultPointY})");


