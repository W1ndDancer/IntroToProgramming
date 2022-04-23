// Programm will show a last numeric of the three-digit number

Console.WriteLine("Input an integer number");
int num = Convert.ToInt32(Console.ReadLine());
int lastNum;
if (num > 99 && num < 999 || num < -99 && num > -1000)
{
    lastNum = Math.Abs(num) % 10;
    Console.Write("Last numeric of your three-digit number is " + lastNum);
}

else
    Console.WriteLine("Bro, its not a three-digit number. Bye!");