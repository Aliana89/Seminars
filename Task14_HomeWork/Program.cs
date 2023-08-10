bool CheckWeekend(int dayNum, int dayNum6, int dayNum7)
{
    return dayNum % dayNum6 == 0 || dayNum % dayNum7 == 0;
}

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek > 7)
{
    Console.WriteLine("Это не день недели");
}
else
{
bool result = CheckWeekend(dayWeek, 6, 7);
Console.WriteLine(result ? "Выходной" : "Не выходной");
}

