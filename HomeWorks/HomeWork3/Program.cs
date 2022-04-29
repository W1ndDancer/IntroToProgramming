// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void checkIfPalindrome(int number)
{
    int n = number;
    int lastDigit;
    int reverseNumber = 0;
    while(n>0)
    {
        lastDigit = n%10;
        reverseNumber = reverseNumber*10 + lastDigit;
        n = n/10;
    }
    if (number == reverseNumber)
        Console.Write(number + " --> IS a palindrome number");
    else
        Console.Write(number + " --> ISN'T a palindrome number");
}

Console.Write("Input five-digit number --> ");
int num = Convert.ToInt32(Console.ReadLine());

if(num>9999 && num<100000)
    checkIfPalindrome(num);
else
    Console.Write("Wrong number, bro. WASTED ");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distX12 = x2 - x1;
    double distY12 = y2 - y1;
    double distZ12 = z2 - z1;

    double distBetween2Points = Math.Sqrt(distX12 * distX12 + distY12 * distY12 + distZ12 * distZ12);
    return distBetween2Points;
}

Console.Write("Input X coordinate of A point --> ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate of A point --> ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z coordinate of A point --> ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("A("+xA+"; "+yA+"; "+zA+")");

Console.Write("Input X coordinate of B point --> ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate of B point --> ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z coordinate of B point --> ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("B("+xB+"; "+yB+"; "+zB+")");

double distanceAB = distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Distance between points is --> " + distanceAB);
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void showCubeList(int n)
{
    int cubeCount = 1;
    while (cubeCount <= n)
    {
        Console.Write(cubeCount * cubeCount * cubeCount + "; ");
        cubeCount++;
    }
}

Console.Write("Input integer number > 0 --> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>0)
    showCubeList(num);
else
    Console.Write("WASTED");
*/
