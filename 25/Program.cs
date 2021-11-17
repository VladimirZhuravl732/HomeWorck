// Найти сумму чисел от 1 до А

int number = 1;
int A = 250;
int summ = 0;
while (number <= A)
{

    summ = summ + number;
    System.Console.Write(number + " ");
    number++;
}
System.Console.WriteLine($"" + " сумма чисел" + " " + summ);