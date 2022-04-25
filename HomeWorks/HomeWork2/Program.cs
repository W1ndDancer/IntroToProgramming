// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int Show2ndDigit(int n)
{
    int del1stDigit = n/10;
    int del3dDigit = del1stDigit%10;
    return del3dDigit;
}

Console.Write("Input some three-digit number ---> ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > -1000 && num < -99 || num > 99 && num < 1000)
{
    num = Math.Abs(num);
    int digit2nd = Show2ndDigit(num);
    Console.Write("2nd digit is ---> " + digit2nd);
}
else
    Console.Write("Dont try to break my programm. Its not a three-digit number");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет