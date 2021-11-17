//12. Удалить вторую цифру трёхзначного числа

int n = 790;
int RemoveSecondDigit(int n)
{
    int num1 = n / 100;
    int num3 = n % 10;
    return num1 * 10 + num3;

}
Console.WriteLine(RemoveSecondDigit(n));