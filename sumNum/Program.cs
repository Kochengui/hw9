Console.Write("Ввод числа M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввод числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNum(m, n);

void SumNum(int m, int n)
{
    Console.Write(SummaMN(m - 1, n));
}

int SummaMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SummaMN(m, n);
        return result;
    }
}