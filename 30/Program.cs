// Показать кубы чисел, заканчивающихся на четную цифру

int number = 1;
int N = 10;

while (number <= N)
{
    int result= number*number*number;
    if (result % 2 ==0)
    {
          System.Console.WriteLine($"Куб числа {number} = {result}");
    }
    
    number++;
}


/*int N = 10;

for (int i = 1; i <= N; i++)
{
    int result = i * i * i;
    if (result % 2 == 0)
    {
        System.Console.WriteLine($"Куб числа {i} = {result}");
    }
}
*/