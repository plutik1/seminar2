
 Console.WriteLine("количество строк   ");
int size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("количество стобцов");
int size1 = Convert.ToInt32(Console.ReadLine());
 //int size =2;
//int size1=3;
Console.WriteLine("массив: ");
 double[,] mas = new double[size,size1];
//double q = 0;
masadd(mas);
masgift(mas);

void masadd(double[,] mas)//ввод одномерного массива
{
    for(int i=0; i < size; i++)
    {
        for( int j=0; j < size1; j++)
        {
           // Console.Write($"Пересечение в точке: ({j})");
        
            mas[i,j] = Convert.ToDouble(new Random().Next(100,10000)) / 100;
            
            
        }
       // Console.WriteLine(j);
    }
}



void masgift(double[,] mas)//ввод одномерного массива
{
    for(int i=0; i < size; i++)
    {
         
        for( int j = 0; j < size1; j++)
        {
            Console.Write($"{mas[i,j]} ");
           
        }
        if (i!=size-1)
            {
                Console.WriteLine("");
            }
    }
}

