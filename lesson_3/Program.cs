// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine()); 

bool CheckNumber(int num)
{
    string str = num.ToString();
    int[] arrayN = new int[str.Length];
    for( int i = 0; i < str.Length; i++){
        arrayN[i] = int.Parse(str[i].ToString());
    }

    if(arrayN[0]==arrayN[4] && arrayN[1] == arrayN[3])
    {

        return true;
    }
    return false;
}

bool resultN = CheckNumber(number);

if(resultN == true)
{
   Console.WriteLine("Да, число является палиндромом"); 
}
else{
   Console.WriteLine("Нет, число не является палиндромом"); 
}

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/

 Console.WriteLine("Введите координаты первой точки");
 double x1 = Convert.ToInt32(Console.ReadLine());
 double y1 = Convert.ToInt32(Console.ReadLine());
 double z1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите координаты второй точки");
 double x2 = Convert.ToInt32(Console.ReadLine());
 double y2 = Convert.ToInt32(Console.ReadLine());
 double z2 = Convert.ToInt32(Console.ReadLine());

 double SearchDistance(double a1, double b1, double c1, double a2, double b2, double c2)
 {
    double distance = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
 }

 double resultC = SearchDistance(x1, y1, z1, x2, y2, z2);
 Console.WriteLine(resultC);

/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

Console.WriteLine("Введите число, которое хотите возвести в куб");
int c = Convert.ToInt32(Console.ReadLine());

int[] TableCubes(int q)
{
    int[] array = new int[q];

    for(int i = 1; i <= c; i++)
    {
        array[i - 1] = i * i * i;
    }
    return array;
}

int[] result = TableCubes(c);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
