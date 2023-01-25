
 Console.WriteLine("количество строк   ");
int size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("количество стобцов");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ваш массив: ");
 double[,] mas = new double[size,size1];
double[] avg = new double[size1];//массив средних арифметич
masadd(mas);
masgift(mas);
masseach(mas);
void masadd(double[,] mas)//ввод одномерного массива
{
    for(int i=0; i < size; i++)
    {
        for( int j=0; j < size1; j++)
        {
       
            mas[i,j] = Convert.ToDouble(new Random().Next(0, 10));
            
            
        }

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

void masseach(double[,] mas)//поиск одномерного массива
{
    Console.WriteLine("");
    double arifmet=0;
    int j=0;
    for(j=0; j < size1; j++)
    {arifmet=0;
for(int i=0; i < size; i++)
    {
        arifmet = (mas[i,j] + arifmet);
        //Console.WriteLine(arifmet);
        // for( j=0; j < size1; j++)
        // {
       
        //    //arifmet= mas[i,j] ;
            
            
        // }

    }
    arifmet=arifmet/size;
    avg[j]=arifmet;
    //Console.WriteLine($"среднее значение {j+1} столбца: {arifmet}");


    }
for (int i=0;i<size1;i++)
    {
        //avg[i]=arifmet;
        Console.WriteLine(avg[i]);
    }

}