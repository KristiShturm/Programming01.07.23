/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//Метод суммы в диапозоне чисел
int GetSumRange(int startNumber, int endNumber)
{
    int sum = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        sum += i;
    }

    return sum;
}

//Запрос исходного числа от пользователя
Console.Write("Напишите число: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumRange(1,a);
Console.WriteLine($"Сумма чисел: {sum}");