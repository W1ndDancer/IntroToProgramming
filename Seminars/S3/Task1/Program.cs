// Task 1. Intro. Program take a point coordinates (x;y) and then program must say in what quarter this point is lying.

/*
int FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}

Console.Write("Input X coordinate --> ");
int xDot = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate --> ");
int yDot = Convert.ToInt32(Console.ReadLine());

int quarterNum = FindQuarter(xDot, yDot);

if (quarterNum == 0)
    Console.Write("The dot is on the axes");
else
    Console.Write("Number of quarter is " + quarterNum);

*/

// Task 1.2. Program take a number of quarter and then program must show range for x and y coordinates for this quarter

/*

void FindCoordinates(int quarterNum)
{
    if (quarterNum == 1)
        Console.Write("For 1st quarter corrdinates must be x>0 and y>0");
    if (quarterNum == 2)
        Console.Write("For 2nd quarter corrdinates must be x<0 and y>0");
    if (quarterNum == 3)
        Console.Write("For 1st quarter corrdinates must be x<0 and y<0");
    if (quarterNum == 4)
        Console.Write("For 1st quarter corrdinates must be x>0 and y<0");
}

Console.Write("Input number of the quarter --> ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter > 4 || quarter <= 0)
    Console.Write("This quarter isnt exist");
else
    FindCoordinates(quarter);

*/
