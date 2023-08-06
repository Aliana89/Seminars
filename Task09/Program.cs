//Напишите программу , которая будет принимать на
//вход два числа и выводить, является ли первое число кратным второго. 
//Если первое число не кратно 
//второму, то программа выводит остаток от деления
// 34,5-> не кратно, остаток 4;
// 16,4->кратно

int Remainder(int first, int second)
{
    return first % second;
}

Console.WriteLine("Введите два числа");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) 
Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно, остаток --> {remainder}");
