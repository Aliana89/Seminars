//Напишите программу, которая 
//принимает на вход число (N) и выдает 
//таблицу кубов чисел от 1 до N
//3 -> 1,8,27
//5 -> 1,8,27,64,125

void WriteTableСube(int number)
{
    int i = 1;
    while (i <= number)

    {
        Console.WriteLine($"{i, 3} -> {i*i*i, 6}");
        i++;
    }
}
Console.Write("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());

WriteTableСube(n);