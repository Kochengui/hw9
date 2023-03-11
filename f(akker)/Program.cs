Console.Write("Ввод числа M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввод числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkerFunct(m,n);

void AkkerFunct(int m, int n)
{
    Console.Write(Akker(m, n)); 
}

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}