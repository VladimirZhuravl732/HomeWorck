// Найти сумму чисел от 1 до А

int number = 1;
int A = 10;
int summ = 0;
while (number <= A)
{

    summ = summ + number;
    //number++;
    System.Console.Write(number + " " + " сумма чисел" + " ");
    System.Console.WriteLine(summ);
    number++;
}
