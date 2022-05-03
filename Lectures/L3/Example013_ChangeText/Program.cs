﻿// Program  have a text and must swap spaces to "_", к --> К, с --> С
// string s = "qwertz"
// s[3] = r


string text = "- Я думаю, - сказал князь, улыбаясь, что - "
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие русского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;

    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
