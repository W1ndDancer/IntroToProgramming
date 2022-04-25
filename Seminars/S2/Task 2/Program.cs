// Task 2.1 Program must give out random three-digit number, and delete 2nd digit

/*
void Random3DigitNumber()
{
    int num = new Random().Next(100, 1000);
    int firstDigit = num/100;
    int thirdDigit = num%10;
    // Deleting2ndDigit = firstDigit*10 + thirdDigit --> Console.Write(Deleting2ndDigit)

    Console.Write(num + " deleting 2nd digit.... Result is " + firstDigit + thirdDigit);
}
Random3DigitNumber();
*/

// Task 2.2 Programm must take 2 random numbers and ckeck if possible to divide this numbers, if not program must show a reminder

/*
void Divide2numbers(int n1, int n2)
{   
    int divNotpossible = n1%n2;
    int divPossible = n1/n2;

    if (divNotpossible == 0)
        Console.Write("This numbers can be divided. Result is --> " + divPossible);
    else
        Console.Write("This numbers CAN'T be divided. Remainder is --> " + divNotpossible);
}

Console.Write("1st number is --> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("And 2nd is --> ");
int num2 = Convert.ToInt32(Console.ReadLine());
Divide2numbers(num1,num2);
*/

// Task 2.3 Program must take from user a number and check if possible to divide this numbers on 7 and 23

/*
void Divide2numbers(int n)
{
    int div7 = n % 7;
    int div23 = n % 23;

    if (div7 == 0 && div23 == 0) // We could check if our number is multiple to 7*23=161, because 7 amd 23 are simple numbers.
        Console.Write("This number can be divided on 7 and 23");
    else
        Console.Write("This numbers CAN'T be divided on 7 and 23");
}

Console.Write("Input an integer number ---> ");
int num = Convert.ToInt32(Console.ReadLine());

Divide2numbers(num);
*/

// Task 2.4 Programm must check if number A is equal number B^2. Method must be used.

/*
void checkSqr(int num1, int num2)
{
if (num1 == num2 * num2)
    Console.WriteLine("1st number is equal to square of the 2nd number");
else
    Console.WriteLine("1st number is NOT equal to square of the 2nd number");
}

Console.Write("Input 1st integer number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd integer number: ");
int numB = Convert.ToInt32(Console.ReadLine());

checkSqr(numA,numB);
*/
