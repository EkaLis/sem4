// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumma (int num)
{
    int count = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    { 
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}

int Summa = GetSumma (num);
Console.WriteLine (Summa);

