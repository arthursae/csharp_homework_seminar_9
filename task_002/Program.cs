// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfAllElementsWithinTheRange(int fromNumber, int toNumber, int sum = 0)
{
    if (fromNumber > toNumber)
    {
        int temp = toNumber;
        toNumber = fromNumber;
        fromNumber = temp;
    }

    sum += fromNumber;
    return (fromNumber == toNumber)
        ? sum
        : GetSumOfAllElementsWithinTheRange(fromNumber + 1, toNumber, sum);
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
int m = GetUserInputData("Введите натуральное число M: ");
int n = GetUserInputData("Введите натуральное число N: ");
int result = GetSumOfAllElementsWithinTheRange(m, n);

if(m > n)
{
    int temp = n;
    n = m;
    m = temp;
}

Console.Write("Сумма натуральных элементов в промежутке от " + m + " до " + n + " равна = " + result + "\n");
