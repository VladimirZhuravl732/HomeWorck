// Написать программу вычисления произведения чисел от 1 до N

int N = 3;
int res = 1;
for (int number = 1; number <= N; number++)     
{
    System.Console.WriteLine(number + " ");
    res = res * number;
}
System.Console.WriteLine("Произведение чисел" + " " + res);
