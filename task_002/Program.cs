// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

uint GetSumOfAllElementsWithinTheRange(uint fromNumber, uint toNumber)
{
    if (fromNumber > toNumber)
    {
        uint temp = toNumber;
        toNumber = fromNumber;
        fromNumber = temp;
    }

    return (fromNumber == toNumber)
        ? fromNumber
        : fromNumber + GetSumOfAllElementsWithinTheRange(fromNumber + 1, toNumber);
}

uint GetUserInputData(string msg)
{
    Console.Write(msg);
    string rawUserInput = Console.ReadLine();

    if (UInt32.TryParse(rawUserInput, out _))
    {
        uint num = Convert.ToUInt32(rawUserInput);
        return (num > 0) ? num : GetUserInputData(msg);
    }
    else
    {
        Console.WriteLine("Неправильный тип данных, повторите ввод!");
        return GetUserInputData(msg);
    }
}
Console.Clear();
uint m = GetUserInputData("Введите натуральное число M: ");
uint n = GetUserInputData("Введите натуральное число N: ");
uint result = GetSumOfAllElementsWithinTheRange(m, n);

if(m > n)
{
    uint temp = n;
    n = m;
    m = temp;
}

Console.Write("Сумма натуральных элементов в промежутке от " + m + " до " + n + " равна = " + result + "\n");
