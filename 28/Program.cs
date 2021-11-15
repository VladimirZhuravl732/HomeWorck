// Подсчитать сумму цифр в числе

int number = 333;
int result = 0;

while (number > 0)
{

    result = result + (number % 10); // число 3
    number = number / 10;
}
System.Console.WriteLine(result);
