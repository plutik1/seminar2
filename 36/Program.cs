Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];

Console.WriteLine("массив: ");

int q = 0;





    for(int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100,1000);
    }

  for (int i = 0; i < mas.Length; i=i+2)
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
Console.WriteLine($"всего {mas.Length} чисел, {q} cумма на нечетных позициях");