Console.WriteLine("введите число"); 
int input = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[input+1];
int z=0;
for (int i=5; i>=0; i--)
    {
        z=input % 10;
        arr[i]=z;
        //Console.WriteLine(arr[i]); 
        input=input/10;
       
    }
if (arr[1]==arr[5] &&arr[2]==arr[4])
    {
      Console.WriteLine("полиндром");   
    }
    
else{
       Console.WriteLine(" не полиндром"); 
    }