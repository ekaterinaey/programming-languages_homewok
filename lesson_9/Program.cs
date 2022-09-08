// See https://aka.ms/new-console-template for more information


/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/


Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());


string s = String.Empty;

string OutputNumbersInRange(string str, int num, int fromNum)
{
    str = $"{Convert.ToString(fromNum)} ";

    if(num == fromNum)
    {
        return str;
    }
    else
    {
        str = OutputNumbersInRange(str, num - 1, fromNum) + $"{Convert.ToString(num)} ";
    }
    return str;

}

string result = OutputNumbersInRange(s, n, m);
Console.WriteLine(result);


/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.WriteLine("Введите число N");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m2 = Convert.ToInt32(Console.ReadLine());


int FindSum(int valueM, int valueN)
{
   int result = 0;
   if(valueN ==valueM)
   {
    return 0;
   }
   else
   {
    valueM++;
    result = valueM + FindSum(valueM, valueN);
    return result;
   }

}

int resultFindSum = FindSum(m2 - 1 , n2);
Console.WriteLine(resultFindSum);


 /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
  Даны два неотрицательных числа m и n.*/

Console.WriteLine("Введите число N");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m3 = Convert.ToInt32(Console.ReadLine());

int EvaluationFunctionAkkerman(int valueM2, int valueN2)
{
    int result3 = 0;
    if(valueM2==0)
    {
        result3 = valueN2 +1;
        return result3;
    }
    else if ((valueM2 > 0 && valueN2 == 0))
    {
    
        result3 = EvaluationFunctionAkkerman(valueM2 - 1, 1);
        return result3;
    
    }
    else
    {
        if(valueM2 > 0 && valueN2 > 0)
    {
        
        result3 = EvaluationFunctionAkkerman(valueM2 - 1, EvaluationFunctionAkkerman(valueM2, valueN2 - 1));
        return result3;
    }
    }
    return result3;

}

int resultEvaluationFunctionAkkerman = EvaluationFunctionAkkerman(m3, n3);
Console.WriteLine(resultEvaluationFunctionAkkerman);