Console.Write("Напишите целое число: ");
int N = int.Parse(Console.ReadLine());
 
int count = 0;
while (count < N-1)
{
    count = count + 2;
    Console.WriteLine(count);
}
