using static System.Console;
Console.WriteLine("Введите  число.");
int s=0;
int i=0;
int j=0;
int itog=0;
int input = Convert.ToInt32(Console.ReadLine());
for(int o=0; input>=1000;o++)// плюсовая часть ленты
     {
          input = input / 10;
          //Console.WriteLine(input);
     }

if ( input > 100 && input<1000  )
     {
     for ( i = 0; i < input; i=i+10 )
    {
         
         s=i;
       
    }
    
    for( j=0 ;s<input;j++)
            {
                   s=s+1; 
                   itog= itog + 1;
                    
            }

Console.WriteLine(itog);
     }
if ( input > 0 && input<100  )
{
//Console.WriteLine("третьего числа нет"); 
}

for(int o=0; input<=-1000;o++)//минусовая часть
     {
          input = input / 10;
         
     }

if ( input <-100 && input>-1000  )
     {
     for ( i = 0; i > input; i=i-10 )
    {
         
         s=i;
         
       
    }
    
    for( j=0 ;s>input;j++)
            {
                   s=s-1; 
                   itog= itog + 1;
                    Console.WriteLine(s);
            }

Console.WriteLine(itog);
     }
if ( input < 0 && input>-100  )
{
Console.WriteLine("третьего числа нет"); 
}