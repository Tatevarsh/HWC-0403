// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 1;

while (sum <= num)
{
    int cube = sum * sum * sum;
            if (cube % 2 == 0)
                
            {
                Console.WriteLine($"число " + sum);
                Console.WriteLine($"куб  " + cube);
            }
   
   sum++; 
} 

    

   


