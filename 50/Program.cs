
 Console.WriteLine("количество строк   ");
int size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("количество стобцов");
int size1 = Convert.ToInt32(Console.ReadLine());
 //int size =2;
//int size1=3;
Console.WriteLine("ваш массив: ");
 double[,] mas = new double[size,size1];
//double q = 0;
masadd(mas);
masgift(mas);
masseach(mas);
void masadd(double[,] mas)//ввод одномерного массива
{
    for(int i=0; i < size; i++)
    {
        for( int j=0; j < size1; j++)
        {
           // Console.Write($"Пересечение в точке: ({j})");
        //Random rnd = new Random();
       // int value = rnd.Next(0, 10);
            mas[i,j] = Convert.ToDouble(new Random().Next(0, 10));
            
            
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

void masseach(double[,] mas)//ввод одномерного массива
{
    Console.WriteLine("");
    Console.WriteLine("какой элемент ищем?");
    Console.WriteLine("введите строку ");
    int seach = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите столбец ");
    int seach1 = Convert.ToInt32(Console.ReadLine());
    if (seach>size||seach1>size1)
    {
        Console.WriteLine("такого элемента нет");
    }
    else {
        Console.WriteLine(mas[seach,seach1]);
    }
    // for(int i=0; i < size; i++)
    // {
         
    //     for( int j = 0; j < size1; j++)
    //     {
    //        if (i==seach)
    //         {
    //             Console.WriteLine($"{mas[i,j]->}");
    //         }
           
    //     }
        
    // }
}