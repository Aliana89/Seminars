//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36



int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        checked
        {
        sum += i; // sum = sum + 1
        }
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
 
int sumNumbers = SumNumbers(number);
if(number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

