// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int GetNumber()
// {
//     Console.WriteLine("Введите число");
//     int number = Int32.Parse(Console.ReadLine());
//     return number;
// }

// int newNumber = GetNumber();

// if ( newNumber > 99 && newNumber < 1000 )                         РАБОТАЕТ ТОЛЬКО С ТРЕХЗНАЧНЫМИ ЧИСЛАМИ
// {
//     int thirdDigit = newNumber % 10;
//     Console.WriteLine(thirdDigit);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }
// --------------------------------------------------------------------------------------------------

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

int newNumber = GetNumber();

if ( newNumber < 100 )
{
    Console.WriteLine("третьей цифры нет");
}
else if ( newNumber > 99 && newNumber < 1000 )
{
    int thirdDigit = newNumber % 10;
    Console.WriteLine(thirdDigit);
}
else if ( newNumber > 999 && newNumber < 10000)             // работает до шестизначных чисел
{                                                           // в тест-кейсе максимальное число пятизначное,
    int leftover = newNumber % 100;                         // поэтому ок
    int thirdDigit = leftover / 10;
    Console.WriteLine(thirdDigit);
}
else if ( newNumber > 9999 && newNumber < 100000)       
{                                                       
    int leftover = newNumber % 1000;                     
    int thirdDigit = leftover / 100;                    
    Console.WriteLine(thirdDigit);                      
}                                                       
else if ( newNumber > 99999 && newNumber < 1000000)
{
    int leftover = newNumber % 10000;
    int thirdDigit = leftover / 1000;
    Console.WriteLine(thirdDigit);
}

// тут можно добавлять нули и девятки до бесконечности,
// нужно для чисел, с которыми сравниваем заданное 
// число, завести переменные, созависимые с переменными, 
// на которые делим для получения остатка и третьей цифры
// и с количеством цифр в заданном числе
// чтобы программа работала для любого числа



// int GetNumber()
// {
//     Console.WriteLine("Введите число");
//     int number = Int32.Parse(Console.ReadLine());
//     return number;
// }

// int newNumber = GetNumber();

// if ( newNumber < 100 )
// {
//     Console.WriteLine("третьей цифры нет");
// }

// string numberStr = Convert.ToString(number);
// int numberLenght = numberStr.Length;



// if ( numberLenght == 3 )
// {
//     int leftover = newNumber % 100;
//     int thirdDigit = leftover % 10;
//     Console.WriteLine(thirdDigit);
// }

