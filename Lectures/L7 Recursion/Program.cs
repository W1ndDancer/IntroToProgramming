 void Towers(string First = "1", string Third = "3", string Second = "2", int count = 3)
{
    Console.WriteLine($"{First} --> {Third}");
    if (count > 1) Towers(First, Second, Third, count - 1);
    //Console.WriteLine($"{First} --> {Third}");
    if (count > 1) Towers(Second, Third, First, count - 1);
}

Towers();