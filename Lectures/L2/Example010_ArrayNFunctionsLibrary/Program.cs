void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position] + " ");
        position++;
    }
}

//Solving past task using array and methods.
int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Create new array what will contain 8 elements. Default array will be filled with 0.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 8);
if(pos == -1)
    Console.WriteLine("Its a pity. I am not here");
else
    Console.Write("Im here >>>---->" + pos);
