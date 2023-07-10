/*Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
*/

double GetPow(double numberA, double numberB)
{
    double result = 0;
    result = Math.Pow(numberA , numberB);
    return result;
}


Console.Write("Напишите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
double b = double.Parse(Console.ReadLine());

double result = GetPow(a , b);
Console.Write($"{result}");
