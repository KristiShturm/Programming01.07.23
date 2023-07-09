//Проверить число, является ли палиндромом

bool IsPalindrome(int number)
{
    int revNumber = 0;
    int sourceNumber = number;

    while (sourceNumber != 0)
    {
        int pop = sourceNumber % 10;
        sourceNumber = sourceNumber / 10;

        //Формирование нового числа (обратное от исходного)
        revNumber = (revNumber * 10) + pop;
    }

    bool isResult = revNumber == number;

    return isResult;
}

//bool result = IsPalindrome(number);
//Console.WriteLine(result);

Console.Write("Напишите число: ");
int number = int.Parse(Console.ReadLine());

bool result = IsPalindrome(number);
Console.WriteLine($"Число является палиндромом: {result}");

