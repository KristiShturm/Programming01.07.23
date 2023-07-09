/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetComposition (int number)
{
    int composition = 1;
    for(int i = 1; i <= number; i++)
    {
        composition = composition * i;     
    }
    return composition;
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());

num = GetComposition (num);
Console.Write($"Произвеение чисел: {num}");
