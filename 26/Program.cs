// Возведите число А в натуральную степень числа В используя цикл
int toPower(int number, int degree) //2, 4
{
    int result = 1;  // result =1

    for (int i = 1; i <= degree; i++)
    {
        result = result * number;  // result =2
    }
    return result;
}

if (8 == toPower(2, 3))
{
    System.Console.WriteLine("Работает корректно");
}
else
{
    System.Console.WriteLine("Ошибочка вышла");
}

if (225 == toPower(15, 2))
{
    System.Console.WriteLine("Работает корректно");
}
else
{
    System.Console.WriteLine("Ошибочка вышла");
}

if (1024 == toPower(2, 10))
{
    System.Console.WriteLine("Работает корректно");
}
else
{
    System.Console.WriteLine("Ошибочка вышла");
}
