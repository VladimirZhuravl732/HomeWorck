// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] FillArray(double[] Fill)
{
    for (int i = 0; i < Fill.Length; i++)
    {
        Fill[i] = new Random().NextDouble() * 10;
    }
    return Fill;
}

double[] PrintArray(double[] Print)
{
    for (int i = 0; i < Print.Length; i++)
    {
        System.Console.WriteLine(Print[i] + " ");
    }
    return Print;
}

void DiffMaxMin(double[] Difference)
{
    double MaxElem = Difference[0];
    double MinElem = Difference[0];
    for (int i = 1; i < Difference.Length; i++)
    {
        if (Difference[i] > MaxElem)
        {
            MaxElem = Difference[i];
            //Difference[i]++;
        }
        if(Difference[i]<MinElem)
        {
            MinElem = Difference[i];
        }
    }
    double result=MaxElem-MinElem;
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Разница" + result);
}


double[] Array = new double[10];


Array = FillArray(Array);
PrintArray(Array);
DiffMaxMin(Array);


