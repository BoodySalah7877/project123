// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,MR NAZROOT");

Console.Write("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
{

        int z, b, sum;

        int m1n, m2x;

Console.Write("\n\n");

Console.Write("Find perfect numbers within a given number of range:\n");

Console.Write("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

Console.Write("\n\n");

Console.Write("Input the starting range or 1number : ");

m1n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the ending range of 2number : ");

m2x = Convert.ToInt32(Console.ReadLine());

Console.Write("The Perfect numbers within the given range : ");

for (z = m1n; z <= m2x; z++)
{
    b = 1;
    sum = 0;
    while (b < z)
    {
        if (z % b == 0)
            sum = sum + b;
        b++;
    }
    if (sum == z)
        Console.Write("{0} ", z);
}

Console.Write("\n");

 }
    