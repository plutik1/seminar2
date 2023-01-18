//using System;
Console.WriteLine("число"); 
string a = Console.ReadLine();
int lent = a.Length;
//Console.WriteLine(lent); 
int summ=0;
int sum=0;
int Z=0;
for (int i=0; i<lent; i++)
    {
     if (a[i]==48)
            {
                Z=0;
            }
            if (a[i]==49)
            {
                Z=1;
            }
            if (a[i]==50)
            {
                Z=2;
            }
            if (a[i]==51)
            {
                Z=3;
            }
             if (a[i]==52)
            {
                Z=4;
            }
             if (a[i]==53)
            {
                Z=5;
            }
             if (a[i]==54)
            {
                Z=6;
            }
            if (a[i]==55)
            {
                Z=7;
            }
            if (a[i]==56)
            {
                Z=8;
            }
            if (a[i]==57)
            {
                Z=9;
            }
   summ=Z+summ;
sum=sum+Int32.TryParse(a[i], out int j);
    Console.WriteLine(j); 
    }
//Console.WriteLine("сумма всех числел:"); 
//Console.WriteLine(summ); 