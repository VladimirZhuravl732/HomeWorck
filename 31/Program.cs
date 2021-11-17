// Задать массив из 8 элементов и вывести их на экран

int[] CreateArray(int index)
{
    int[] Array = new int[index];
    for (int i = 0; i < index; i++)
    {
        Array[i] = new Random().Next(10, 100);
        Console.WriteLine(Array[i] + " ");
    }
    return Array;
}
CreateArray(8);