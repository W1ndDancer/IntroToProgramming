// Method 1. Take nothing, no return
/*
void Method1()
{
    Console.Write("Authot ...");
}

Method1();
*/

//Method 2. Take something, no return
/*
void Method2(string msg, int count)
{
    Console.Write(msg);

}
Method2(msg: "some text");
*/

//Method 2.1
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21("some text", 5); 
// Method2(count: 5, msg: "Some text"); //its the same
*/

//Method 3. Take nothig, but return
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.Write(year);
*/

//Method 4. Take smt, and return
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10,"ADFS ");
Console.Write(res);
*/

/*
string Method4(int count, string text)
{
   string result = String.Empty;
   for(int i = 0; i<count; i++)
   {
       result = result + text;
   }
   return result;
   
}
string res = Method4(10,"ADFS ");
Console.Write(res);
*/