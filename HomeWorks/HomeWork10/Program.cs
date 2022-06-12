// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

/*
string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element --> ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

int CountHowMuchWordsStartWithVowels(string[] words)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    int count = 0;

    for (int i = 0; i < words.Length; i++)
    {
        words[i] = words[i].ToLower();
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i][0] == vowels[j])
            {
                count++;
                break;
            }
        }
    }
    return count;
}

Console.Write("Input size of array --> ");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = CreateStringArray(size);

ShowArray(newArray);
Console.Write(CountHowMuchWordsStartWithVowels(newArray) + " words starting with vowel");
*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

/*
string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element --> ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

string[] CombinePairedElements(string[] words)
{
    if (words.Length % 2 == 0)
    {
        string[] newWords = new string[(words.Length) / 2];

        for (int i = 0; i < words.Length; i += 2)
        {
            newWords[i - i / 2] = words[i] + words[i + 1];
        }
        return newWords;
    }
    else
    {
        string[] newWords = new string[(words.Length) / 2 + 1];

        for (int i = 0; i < words.Length; i += 2)
        {
            if (i == words.Length - 1) newWords[i - i / 2] = words[i];
            else newWords[i - i / 2] = words[i] + words[i + 1];
        }
        return newWords;
    }
}

Console.Write("Input size of array --> ");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = CreateStringArray(size);
ShowArray(newArray);
Console.WriteLine();

string[] newArray2 = CombinePairedElements(newArray);
ShowArray(newArray2);
*/