int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumber(number, count);


void NaturalNumber(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumber(n, count + 1);
        Console.Write(count + " ");
    }
}

