// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine();
// System.Console.WriteLine("*Задача № 10. Вывести вторую цифру из трехзначного числа*");
// System.Console.WriteLine();

// System.Console.WriteLine("Введите трехзначное число");

// if (!int.TryParse(Console.ReadLine(), out int number))
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }

// if (number < 0)
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите положительное число");
//     return;
// }

// int length = number.ToString().Length;

// if (length == 3)
// {
//     int result = number / 10 % 10;
//     System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine();
// System.Console.WriteLine("*Задача № 13. Вывести 3-ю цифру из заданного числа*");
// System.Console.WriteLine();

// System.Console.WriteLine("Введите число");

// if (!int.TryParse(Console.ReadLine(), out int number))
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }

// if (number < 0)
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите положительное число");
// }

// int length = number.ToString().Length;

// if (length >= 3)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     int result = number % 10;
//     System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// System.Console.WriteLine();
// System.Console.WriteLine("*Задача № 15. Проверка на выходной день*");
// System.Console.WriteLine();

// System.Console.WriteLine("Введите день недели:");

// int day = Convert.ToInt32(Console.ReadLine());

// if (day >= 1 && day <= 7)
// {
//     if (day >= 6)
//     {
//         System.Console.WriteLine("да");
//     }
//     else
//     {
//         System.Console.WriteLine("нет");
//     }
// }
// else
// {
//     System.Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }



