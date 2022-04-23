//Task4. User input integer number and programm find interval from [-n;n] and showing all integer numbers in this interval

Console.WriteLine("Hey! Input an integer number.");
int num = Convert.ToInt32(Console.ReadLine());

/*

// My variant

int antinum = -num;

if (num >= 0)
{
    while (antinum <= num)
    {
        Console.Write(antinum + " ");
        antinum++; //is equal: antinum = antinum+1
    }
}
else
{
    while (antinum >= num)
    {
        Console.Write(num + " ");
        num++;
    }
}
*/

// Seminar variant
int antinum;
if (num >= 0)
{
    antinum = -num;
}
else
{
    antinum = num;
    num = -num;
}
while (antinum <= num)
{
    Console.Write(antinum + " ");
    antinum++;
}