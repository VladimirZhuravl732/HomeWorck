// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] FillArray(int[] Fill)
{
    for (int i = 0; i < Fill.Length; i++)
    {
        Fill[i] = new Random().Next(0, 50);
    }
    return Fill;
}
int[] PrintArray(int[] Print)
{
    for (int i = 0; i < Print.Length; i++)
    {
        System.Console.Write(Print[i] + " ");
    }
    return Print;
}
void SumOddIndex(int[] Sum)
{
    int SumNumber = 0;
    for (int i = 0; i < Sum.Length; i++)
    {
        if (i % 2 != 0)
        {
            SumNumber = SumNumber + Sum[i];
        }
    }
    //return SumNumber;
    System.Console.WriteLine();
    System.Console.WriteLine("Сумма чисел стоящих на нечетной позиции" + " " + SumNumber);
}

int[] Array = new int[5];

Array = FillArray(Array);
PrintArray(Array);
SumOddIndex(Array);

