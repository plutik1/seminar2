int[] arr = new int[3];
int[] arr2 = new int[3];
Console.WriteLine("введите координату a1"); 
int input = Convert.ToInt32(Console.ReadLine());
arr[0]=input;
Console.WriteLine("введите координату a2"); 
input = Convert.ToInt32(Console.ReadLine());
arr[1]=input;
Console.WriteLine("введите координату a2"); 
input = Convert.ToInt32(Console.ReadLine());
arr[2]=input;

Console.WriteLine("введите координату б1"); 
 input = Convert.ToInt32(Console.ReadLine());
arr2[0]=input;
Console.WriteLine("введите координату б2"); 
input = Convert.ToInt32(Console.ReadLine());
arr2[1]=input;
Console.WriteLine("введите координату б2"); 
input = Convert.ToInt32(Console.ReadLine());
arr2[2]=input;

double z=   (arr2[0]-arr[0])*(arr2[0]-arr[0])+(arr2[1]-arr[1])*(arr2[1]-arr[1])+(arr2[2]-arr[2])*(arr2[2]-arr[2]);
z=Math.Sqrt(z);

Console.WriteLine(z); 