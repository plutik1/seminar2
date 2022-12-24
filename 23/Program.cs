Console.WriteLine("введите число"); 
int input = Convert.ToInt32(Console.ReadLine());
int z=1;
if (input<0)
    {
         z=0;
        input=input*(-1); 
    }
int[] arr = new int[input+1];


if (z==0)
    {
        for (int i=0; i<=input; i++)
    {
        
        int j=i;
        j=j*j*j*(-1);
       // Console.WriteLine(i); 
        arr[i]=j;
       //  Console.WriteLine(j); 
       Console.WriteLine(arr[i]); 

    }
    }
    if (z==1)
for (int i=0; i<=input; i++)
    {
        
        int j=i;
        j=j*j*j;
       // Console.WriteLine(i); 
        arr[i]=j;
       //  Console.WriteLine(j); 
       Console.WriteLine(arr[i]); 

    }