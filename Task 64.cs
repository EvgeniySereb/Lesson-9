int GetNfromUser(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RecursionN (int n )
{
    int number = 1;
    if (n >= number)
    {
          Console.Write (n + " ");
          RecursionN(n-1);

    }
}
int n = GetNfromUser("Enter N");
RecursionN(n);