using static System.Console;
Console.WriteLine("Введите трехзначное число.");
double input = Convert.ToDouble(Console.ReadLine());
        

    double s =input%100  ;

    input = s / 10;

    int q = Convert.ToInt32(input);
    
Console.WriteLine(q);  
  