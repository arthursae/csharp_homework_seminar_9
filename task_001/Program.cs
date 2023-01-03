// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int OutputOrderedRangeOfNaturalNumbers(int toNumber, int fromNumber = 1, bool isDescending = true)
{
    int min,
        max;

    if (fromNumber > toNumber)
    {
        max = fromNumber;
        min = toNumber;
    }
    else
    {
        max = toNumber;
        min = fromNumber;
    }

    if (fromNumber == toNumber)
    {
        Console.Write(fromNumber + "\n");
        return fromNumber;
    }

    if (isDescending)
    {
        Console.Write(max + ", ");
        return OutputOrderedRangeOfNaturalNumbers(max - 1, min, true);
    }
    else
    {
        Console.Write(min + ", ");
        return OutputOrderedRangeOfNaturalNumbers(min + 1, max, false);
    }
}

int GetUserInputData(string msg)
{
    Console.Write(msg);
    string rawUserInput = Console.ReadLine();

    if (Int32.TryParse(rawUserInput, out _))
    {
        int num = Convert.ToInt32(rawUserInput);
        return (num > 0) ? num : GetUserInputData(msg);
    }
    else
    {
        Console.WriteLine("Неправильный тип данных, повторите ввод!");
        return GetUserInputData(msg);
    }
}

Console.Clear();

int userInput = GetUserInputData("Введите натуральное число: ");
int lastNum = OutputOrderedRangeOfNaturalNumbers(userInput);
