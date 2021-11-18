// Определить, присутствует ли в заданном массиве, некоторое число 

int[] FindNumber(int find)
{
    int[] Array = new int[10];
    //int find = 20;
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(15, 21);
        System.Console.Write(Array[i] + " ");

        if (Array[i] == find)
        {
            count = count + 1;
        }
    }
    if (count > 0)
    {
        System.Console.WriteLine("Число присутствует в массиве" + " " + count + " " + "раз");
    }
    else
    {
        System.Console.WriteLine("Заданное число отсутствует");
    }
    return Array;
}
FindNumber(15);