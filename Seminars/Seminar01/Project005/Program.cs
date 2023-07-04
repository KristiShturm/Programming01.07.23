Console.Write("Напишите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int second = int.Parse(Console.ReadLine());

if(first > second)
{
    second *= second;
}
else
{
    first *= first;
}
if(first == second)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}