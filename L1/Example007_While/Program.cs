//Run when terminal on +-11 stroke for mac m1pro 16
Console.Clear();
int xA = 80, yA = 1,
    xB = 1, yB = 40,
    xC = 161, yC = 40;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("o");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("o");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("o");

int x = xA, y = yA;
int count = 0;

int ChooseTop1 = new Random().Next(0, 2);
if (ChooseTop1 == 0)
{
    x = (x + xB) / 2;
    y = (y + yB) / 2;
}
if (ChooseTop1 == 1)
{
    x = (x + xC) / 2;
    y = (y + yC) / 2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("o");
count++;

while (count < 25000)
{
    int ChooseTop2 = new Random().Next(0, 3);
    if (ChooseTop2 == 0)
    {
        x = (x + xA) / 2;
        y = (y + yA) / 2;
    }
    if (ChooseTop2 == 1)
    {
        x = (x + xB) / 2;
        y = (y + yB) / 2;
    }
    if (ChooseTop2 == 2)
    {
        x = (x + xC) / 2;
        y = (y + yC) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("o");
    count++;//Its equal (count = count + 1) and its equal (count +=1)

}