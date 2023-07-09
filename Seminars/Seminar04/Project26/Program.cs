/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetCountDigital(int number)
{
    int count = 0;
    int number1 = number;
    while(number1 != 0)
    {
        number1 = number1 / 10;
        count ++;
    }
    return count;
}

Console.Write("Напишите число: ");
int a = int.Parse(Console.ReadLine());

int res = GetCountDigital(a);
Console.Write($"Количество цифр: {res}");