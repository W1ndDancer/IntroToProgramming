Console.Write("Как тебя зовут? ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
     Console.WriteLine("Ура! Это же Маша!");

}
else
{
    Console.Write("А...Опять ты ");
    Console.WriteLine(username);
}

