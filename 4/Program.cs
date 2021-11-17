// Найти максимальное из трех чисел

int number1 = -55;
int number2 = -10;
int number3 = -23;
int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

System.Console.WriteLine(max);

// 2 вариант 
//  4. Найти максимальное из трех чисел
/*
int maxnumber(int a, int b, int c)
{
    int max = a;
    if (a > max) { max = a; };
    if (b > max) { max = b; };
    if (c > max) { max = c; };
    return max;
}
int res = maxnumber(-55, -10, -25);
Console.WriteLine($"Максимальное число {res}");
*/