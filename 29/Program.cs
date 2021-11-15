// Написать программу вычисления произведения чисел от 1 до N

int number = 1;
int N = 3;
int res = 1;
while (number <= N)
{
    System.Console.Write(number + " ");
    res = res * number;
    
    System.Console.WriteLine(res);
    number++;
}

