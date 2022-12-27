double[] a = Console.ReadLine().Split(" ").Select(x=>double.Parse(x)).ToArray();
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i]>0)
    {
        count++;
    }
}

Console.WriteLine(count);