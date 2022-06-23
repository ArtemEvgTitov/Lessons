int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a = new Random().Next(1, 100);
Console.WriteLine(a);
int b = new Random().Next(1, 100);
Console.WriteLine(b);
int c = new Random().Next(1, 100);
Console.WriteLine(c);
int d = new Random().Next(1, 100);
Console.WriteLine(d);
int e = new Random().Next(1, 100);
Console.WriteLine(e);
int f = new Random().Next(1, 100);
Console.WriteLine(f);
int g = new Random().Next(1, 100);
Console.WriteLine(g);
int h = new Random().Next(1, 100);
Console.WriteLine(h);
int i = new Random().Next(1, 100);
Console.WriteLine(i);

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, i);
// int max = Max(max2, max2, max3);

int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, i));

Console.Write("Max = ");
Console.WriteLine(max);