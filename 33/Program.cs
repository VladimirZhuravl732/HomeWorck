// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] Array = new int[12];
int sumpos = 0;
int sumneg = 0;
for (int i = 0; i < Array.Length; i++)
{
    int result = new Random().Next(-5, 10);

    System.Console.Write(result + " " + "сумма");

    if (result > 0)
    {
        sumpos = result + sumpos;
        System.Console.WriteLine(" " + sumpos);
    }
    else
    {
        sumneg = result + sumneg;
        System.Console.WriteLine(" " + sumneg);
    }
    //System.Console.WriteLine(" " + sumpos);
}
