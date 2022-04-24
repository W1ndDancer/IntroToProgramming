// TASK 1. Program must give u a ramdom number in next interval [10;99] and show max numeric of this number.

// 1st var. Using void method
/*
void showmMaxNumeric()
{
    int num = new Random().Next(10, 100);
    int num1st = num / 10;
    int num2nd = num % 10;

    Console.Write(num + " max numeric of this number is ");

    if (num1st > num2nd)
    {
        Console.Write(num1st);
    }
    if (num1st == num2nd)
        Console.Write(num1st + " but, numerics of this number is equal");
    if (num1st < num2nd)
        Console.Write(num2nd);
}

showmMaxNumeric();
*/

// 2nd var. Using Return method

int showmMaxNumeric()
{
    int num = new Random().Next(10, 100);
    int num1st = num / 10;
    int num2nd = num % 10;

    Console.Write(num + " max numeric of this number is ");

    if (num1st >= num2nd)
        return num1st;
    else
        return num2nd;
}

int returnedNumber = showmMaxNumeric();
Console.Write(returnedNumber);