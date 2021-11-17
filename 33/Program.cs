// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] Array = new int[12];
int SumPos = 0;
int SumNeg = 0;
for (int i = 0; i < Array.Length; i++)
{
    int result = new Random().Next(-5, 10);
    if (result > 0)
    {
        SumPos = result + SumPos;
    }
    else
    {
        SumNeg = result + SumNeg;
    }
}
System.Console.WriteLine(" " + "сумма отрицательных" + " " + SumNeg);
System.Console.WriteLine(" " + "сумма положительных" + " " + SumPos);