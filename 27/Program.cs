// Определить количество цифр в числе

int number = 1234567890;
int NumberDigits = 1;
for (NumberDigits = 1; NumberDigits < number; NumberDigits++)
{
    number = number / 10;

}
System.Console.WriteLine("Количество цифр в числе " + NumberDigits);