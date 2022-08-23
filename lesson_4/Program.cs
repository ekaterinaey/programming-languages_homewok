// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.*/

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

int resultExponentiation = Exponentiation(numberA, numberB);
Console.WriteLine(resultExponentiation);


 /*Задача 27: Напишите программу, которая принимает на вход число
  и выдаёт сумму цифр в числе*/

  Console.WriteLine("Введите число"); 
  string number = Console.ReadLine();

  bool isNum = int.TryParse(number, out int result);
  if(isNum == false)
  {
    Console.WriteLine("Вы ввели некорректное число");
  }

  int GetSum(int num)
  {
    int res = 0;
    string n = num.ToString();
    int[] arrayN = new int[n.Length];
    for( int i = 0; i < n.Length; i++){
        arrayN[i] = int.Parse(n[i].ToString());
         
         res = res + arrayN[i];
    }
    return res;
  }

  int resultGetSum = GetSum(result);
  Console.WriteLine(resultGetSum);



  /*Задача 29: Напишите программу, которая задаёт массив из 8 элементов
   и выводит их на экран.*/

 
int[] arrayNumbers = new int[8];
Console.WriteLine("Введите 8 чисел");


int[] FillArray(int[] arr){
      for(int i = 0; i < arr.Length; i++){
        arr[i] = int.Parse(Console.ReadLine());
      
    }
    return arr;
}
  
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}
}

int[] n = FillArray(arrayNumbers);
PrintArray(n);

