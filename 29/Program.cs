int lent = 8;
int[] a = new int[lent];
Random rnd = new Random();
Console.Write("[");
for (int i =0; i<lent; i++)
{
    a[i]=rnd.Next();
    
    if (i==lent-1)
    {
        Console.Write(a[i]);
    }
    else
    {
        Console.Write(a[i] + ", ");
    }
   // Console.Write(", ");
}
Console.Write("]");