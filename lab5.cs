using System.Security.Cryptography;

int plus = 0;
int minus = 0;
Console.WriteLine("введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] a = new int[num];
for (int i = 0; i < a.Length; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < 0)
    {
        minus += 1;
        break;
    }
    else
    {
        plus += 1;
        break;
    }
}
if (minus > plus)
{
    Console.WriteLine("minus");
}
else
{
    Console.WriteLine("plus");
}