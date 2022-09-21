// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int GetNumber()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Int32.Parse(Console.ReadLine());
    return number;
}


int newNumber = GetNumber();

if (newNumber > 99 && newNumber < 1000)
{
    int twoDigits = newNumber / 10;
    int secondDigit = twoDigits % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное!");
}
