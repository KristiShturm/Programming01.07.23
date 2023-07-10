/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе*/

int GetSum (int number)
{
    int number2 = number;
    int result = 0;
    while(number2 != 0)
    {
        result += number2 % 10;
        number2 = number2 /10;
    }
    return result;
}

Console.Write("Напишите число: ");
int a = int.Parse(Console.ReadLine());

int res = GetSum(a);
Console.WriteLine($"Сумма цифр в числе: {res}");

