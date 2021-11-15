// Показать таблицу квадратов чисел от 1 до N

int number = 1;
int N = 10;

while (number < N)
{
    int Square = number * number;
    System.Console.Write(number + " " + "квадрат числа");
    System.Console.WriteLine(" " + Square);
    number++;
}
