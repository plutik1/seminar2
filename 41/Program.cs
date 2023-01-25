
Console.WriteLine("сколько числе нужно ввести?:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] mas = new double[size];

Console.WriteLine("массив: ");

double q = 0;
masadd(mas);


void masadd(double[] mas)//ввод одномерного массива
{



    for(int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToDouble(Console.ReadLine());
        if (mas[i]>0)
        {
            q++;
        }
    }
}

Console.WriteLine($"введеных чисел больше 0 = {q}");
  /*for (int i = 0; i < mas.Length; i=i+2)
//if (mas[i] % 2 == 0)
q=mas[i]+q;

    Console.Write("[ ");//вывод массива
    for(int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
//}

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < mas.Length; z++)
{
    if (mas[z] > max)
        {
            max = mas[z];
        }
    if (mas[z] < min)
        {
            min = mas[z];
        }
}

double w=max-min;
Console.WriteLine($"максимальное {max}, минимальное {min}, разница {w}");
*/