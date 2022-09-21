// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int GetNumber()
{
    Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

int input = GetNumber();

if( input == 1 || input == 2 || input == 3 || input == 4 || input == 5 )
{
    Console.WriteLine("нет");
}
if( input == 6 || input == 7 )
{
    Console.WriteLine("да");
}
