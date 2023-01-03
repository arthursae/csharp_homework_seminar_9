// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint Ackermann(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return Ackermann(n - 1, 1);
    else
        return Ackermann(n - 1, Ackermann(n, m - 1));
}

uint GetUserInputData(string msg)
{
    Console.Write(msg);
    string rawUserInput = Console.ReadLine();

    if (UInt32.TryParse(rawUserInput, out _))
    {
        uint num = Convert.ToUInt32(rawUserInput);
        return (num >= 0) ? num : GetUserInputData(msg);
    }
    else
    {
        Console.WriteLine("Неправильный тип данных, повторите ввод!");
        return GetUserInputData(msg);
    }
}

Console.Clear();
uint n = GetUserInputData("Введите небольшое натуральное число N: ");
uint m = GetUserInputData("Введите небольшое натуральное число M: ");
uint result =  Ackermann(n, m);
Console.WriteLine("A(m,n) = " + result);
