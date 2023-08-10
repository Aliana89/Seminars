//Напишите программу, которая выводит третью цифру задуманного 
//числа или сообщает , что третьего числа нет
//645 -> 5
//78 -> третьего числа нет
//32679 -> 6

int TrirdDigitNumber(int number)
{
while (number >=1000)
{
    number = number / 10;
}
return number % 10;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры - нет");
}
else
{
int Temp = TrirdDigitNumber(number);
Console.WriteLine($"{Temp}");
}

