//Напишите программу , которая принимает на вход
 //трехзначное число и на выходе показывает вторую цифру этого числа
 //456->5;
//782->8;
//918-1.


int ShowSecondDigit(int num)
{
    int thirdDigit = num / 10;
    int secondDigit = thirdDigit % 10;
    return secondDigit;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Неверное число");
}
else
{
int newNumber = ShowSecondDigit(number);
Console.WriteLine($"{newNumber}");
}
