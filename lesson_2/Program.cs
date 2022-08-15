// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/

DeleteNumber();


void DeleteNumber()
{

    Random random = new Random();
    int randomValue = random.Next(100, 1000);

    Console.WriteLine($"Random value - {randomValue}");

    int secondNumber = (randomValue/10)%10;

    Console.WriteLine($"Вторая цифра тоехзначного числа - {secondNumber}");

}


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.*/

 int? SearchThirdNumber(int number)
 {
    if(number.ToString().Length != 3)
    {
        return null;
    }
    int lastNumber = number % 10;
    return lastNumber;
 }

Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());
var number = SearchThirdNumber(input);

if(number == null)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number);
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

bool CheckNumber(int numberD)
{
    if(numberD == 6 || numberD == 7) 
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите цифру дня недели");
int inputD = Convert.ToInt32(Console.ReadLine());
bool result = CheckNumber(inputD);

if(result == true)
{
    Console.WriteLine("Да, этот день выходной");
}
else{
    Console.WriteLine("Нет, это рабочий день");
}


