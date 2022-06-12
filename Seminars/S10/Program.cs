// 1. Написать метод который показывает сколько слов в массиве имеют четное количество букв.

/*
int CountWordsWithEvenLetters(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 == 0) count++;
    }
    return count;
}

string[] someWords = {"kjhguz", "jbkhb", "hmgjhgfh", "jhvhg", "iěa", "jghfcfh", "azxs"};
Console.Write(CountWordsWithEvenLetters(someWords));
*/

// 2. Массив имен отсортировать по количеству букв в слове, от min к max. Если количество букв в имени одинаковое то расположить имена в алфавитном порядке.
// Если первые буквы в имени одинаковые, то сравнить следующие буквы и тд.

/*
void SortStringArray(string[] words)
{
    for (int i = 1; i < words.Length; i++)
    {
        for (int j = 0; j < words.Length - 1; j++)
        {
            int maxWordLenght = words[i].Length;
            if (maxWordLenght < words[j].Length)
            {
                maxWordLenght = words[j].Length;
                string temporary = words[i];
                words[i] = words[j];
                words[j] = temporary;
            }
            if (maxWordLenght == words[j].Length)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if (words[j][k] > words[i][k])
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                        break;
                    }
                    if (words[j][k] < words[i][k]) break;
                }
            }
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

string[] newNames = { "Valerii", "Aryna", "Dmytriy", "Irena", "Valeriy", "Irina", "Svitlana", "Mykhailo", "Nikolay", "Maryna", "Vaheriy" };

SortStringArray(newNames);
ShowArray(newNames);
*/