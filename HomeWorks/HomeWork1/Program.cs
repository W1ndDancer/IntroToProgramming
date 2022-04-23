//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Hey Bro! Do U wanna some magic? I know u want. Pls input some integer number here --> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("And now pls input other integer number here --> ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
    Console.Write(num1 + " is max. I know it was cool)");
else
    Console.Write(num2 + " is max. I know it was cool)");
*/

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write("Hi again bro! I know u want to see another trick. Pls input some integer number here --> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Goooood. Input 2nd integer number righ there --> ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("You awesome, but I need one more number. U alrdy know what to do --> ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;
Console.WriteLine("Max ...wait a minute... is " + max);
*/

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("More magic?! Ok. Just tonight, just for U! Input ur integer number --> ");
int num = Convert.ToInt32(Console.ReadLine());
int remainder = num % 2;
if (remainder == 0)
    Console.Write(num + " its even. Wohooo!");
else
    Console.Write(num + " its NOT even. NOT Wohooo:(");
*/

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("Last trick for today. Ur integer number must be > 1. Input number --> ");
int num = Convert.ToInt32(Console.ReadLine());
int remainder;
int count = 1;
if(num<=1)
    Console.Write("Bro, we are not joking here! Bye!");
while (count <=  num)
{
    remainder = count%2;
    if (remainder == 0)
    {
        Console.Write(count + " ");
        count++;
    }
    else
    count++;
}
*/
