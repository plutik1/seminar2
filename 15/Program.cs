using static System.Console;

Console.WriteLine("введите день недели 1-понедльник....7-воскресенье"); 
int input = Convert.ToInt32(Console.ReadLine());
int o=0;

int[] arr= {1,2,3,4,5,6,7};
//Console.WriteLine(arr[3]); 

for (int i=0; i<6;i++)// заготовка на ввод\вывод массива
    {
         
    }   

    if(input==6 || input ==7)
        {
            Console.WriteLine("да"); 
        }

        if(input==1 || input ==2 || input==3 || input ==4 || input ==5)
        {
            Console.WriteLine("нет"); 
        }