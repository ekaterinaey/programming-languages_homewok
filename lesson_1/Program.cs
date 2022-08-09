// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber){
    Console.WriteLine("Первое число больше");
}
else{
    Console.WriteLine("Второе число больше");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

int maxNumber = numberA;

if(maxNumber > numberB){
    if(maxNumber > numberC)
    Console.WriteLine("Первое число больше");
}
else
{
    if(numberB > numberC){
        Console.WriteLine("Второе число больше");
    }
    else{
        Console.WriteLine("Третье число больше");
    }
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if(n%2 == 0){
    Console.WriteLine("Четное число");
}
else{
    Console.WriteLine("Нечетное число");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<=numberN; i++){
    if(i%2 == 0){
        Console.WriteLine(i);
    }   
}

