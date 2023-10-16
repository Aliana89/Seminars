///Напишите программу, которая принимает на
//вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

bool Palindrome(int number)
{
    if (number < 10000 || number >= 100000)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
    int reverse = 0;
    int temp = number;
    while (temp > 0)
    {
        reverse = reverse * 10 + temp % 10;
        temp /= 10;
    }
    return reverse == number;
}
Console.WriteLine("Введите 5-значное число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(number);
Console.WriteLine($"{result}");

