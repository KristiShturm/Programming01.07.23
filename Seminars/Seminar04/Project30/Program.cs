/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

/*void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); //пустая строка
}
*/
/*﻿void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(1, 10);
        index++;
    }
}
*/
int [] array = new int [8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}

void PrintArray(int [] array)
{
    int count = 0;
    while(count < array.Length)
    {
        Console.Write($"{array[count]} ");
        count++;
    }
}
PrintArray(array);