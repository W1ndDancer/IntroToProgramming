// Написать рекурсивный метод который выводит натуральные числа от 1 до N.

/*
void ShowNumbersToN(int n)
{
    if (n >= 1)
    {
        ShowNumbersToN(n - 1);
        Console.Write(n + " ");
    }
}

ShowNumbersToN(10);
*/

// Написать рекурсивный метод который возводит число а в степень b.

/*
int exponentiateAtoB(int a, int b)
{

    if (b > 1)
    {
        return a * exponentiateAtoB(a, b - 1);
    }
    else return 1;
}

int n = exponentiateAtoB(3, 3);
Console.Write(n);
*/