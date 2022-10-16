int GetNumberfromUser(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers (int m , int n)
{
   int sum =0;
    
    if(m < n)
    {
    
        
        sum = m + SumNumbers(m +1 , n);
     
    }
    else if (m==n)
    {
        sum = sum + n;
    }
   return sum;
}
int n = GetNumberfromUser("Enter N");
int m = GetNumberfromUser("Enter M");
Console.Write(SumNumbers(m , n));