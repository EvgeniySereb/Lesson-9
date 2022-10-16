int GetNumberfromUser(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

int m = GetNumberfromUser("Введите число M : ");
int n = GetNumberfromUser("Введите число N : ");
Console.WriteLine($"Функция Аккермана для чисел({m},{n})= {Akkerman(m,n)}");