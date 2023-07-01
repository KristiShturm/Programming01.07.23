Console.Write("Напишите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
       Console.WriteLine($"Больше число {a}");
}
else 
{
       Console.WriteLine($"Больше число {b}");
}
