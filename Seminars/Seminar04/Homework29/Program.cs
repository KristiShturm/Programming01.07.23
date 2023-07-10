/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

//Ввод числа с экрана

int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result;
}

//метод для получения случайных значений массива
int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int [Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue , maxValue + 1); //заполняем случайными цифрами
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length -1)
        {
            Console.Write($"{array[i]} ]");
            break;          
        }
        Console.Write($"{array[i]}, "); //выводим значения массива
    }  
}

int Length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int [] array = GenerateArray(Length, min, max);
PrintArray(array);


