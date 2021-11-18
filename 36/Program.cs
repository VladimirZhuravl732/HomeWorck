// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел 

int[] Array = new int[10];

int[] FillArray(int[] arr)     // Метод заполнения
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        //System.Console.WriteLine(arr[i]);
    }
    return arr;
}
int[] PrintArray(int[] print)    // Метод выведения
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write(print[i] + " ");
    }
    return print;
}
void SearchCountNumber(int[] count)    // Метод поиска чисел
{
    int CountEvenNumber = 0;
    int CountOddNumber = 0;
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] % 2 == 0)
        {
            CountEvenNumber = CountEvenNumber + 1;
            Array[i]++;
        }
        else
        {
            CountOddNumber = CountOddNumber + 1;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Четных числе в массиве" + " " + CountEvenNumber);
    System.Console.WriteLine("Нечетных чисел в массиве" + " " + CountOddNumber);
}
Array = FillArray(Array);
PrintArray(Array);
SearchCountNumber(Array);




//поиск без метода

/*int CountEvenNumber = 0;
int CountOddNumber = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0)
    {
        CountEvenNumber = CountEvenNumber + 1;
        Array[i]++;
    }
    else
    {
        CountOddNumber = CountOddNumber + 1;
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Четных числе в массиве" + " " + CountEvenNumber);
System.Console.WriteLine("Нечетных чисел в массиве" + " " + CountOddNumber);
*/





