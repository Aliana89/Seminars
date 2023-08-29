///Напишите программу, которая принимает на
//вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да
static double FindDistance3D(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance3D(xCoordinateA, yCoordinateA, zCoordinateA, xCoordinateB, yCoordinateB, zCoordinateB);
Console.WriteLine($"Расстояние между точками -> {Math.Round(result, 2, MidpointRounding.ToZero)}");



using System;

public class Answer
{
private static int Square(int number)
{
return number * number;
}

private static int SumSquare(int[] pointA, int[] pointB)
{
int sum = 0;
for (int i = 0; i < pointA.Length; i++)
{
sum += Square(pointA[i] - pointB[i]);
}
return sum;
}

private static double Length(int[] pointA, int[] pointB)
{
double result = Math.Sqrt(SumSquare(pointA, pointB));
return result;
}

public static void Main(string[] args) {
int x1, x2, x3, y1, y2, y3;

if (args.Length >= 6) {
x1 = int.Parse(args[0]);
x2 = int.Parse(args[1]);
x3 = int.Parse(args[2]);
y1 = int.Parse(args[3]);
y2 = int.Parse(args[4]);
y3 = int.Parse(args[5]);
} else {
x1 = 3;
x2 = 6;
x3 = 8;
y1 = 2;
y2 = 1;
y3 = -7;
}

double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
Console.WriteLine($"{result:F2}");
}
}



void palindrom()
        {
        
         Console.Write("Введите 5-значное число: ");
         int number = Convert.ToInt32(Console.ReadLine()); 
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
        int nul = number / 10000;

     
          if (nul < 1 || nul > 9){
            Console.WriteLine(number + " -> " + "Не 5-значное число");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(number + " -> Палиндром");
            }
            else{
            Console.WriteLine(number + " -> Не палиндром");
            }
            
        }
        for (int i = 0; i < 10; i++)
        
            palindrom();