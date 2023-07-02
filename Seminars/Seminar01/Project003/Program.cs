Console.Write("Напишите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Напишите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write($"Наибольшее число {max} ");


