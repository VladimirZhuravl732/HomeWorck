// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] 
/*int[] Array = new int[123];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(0, 200);
    System.Console.Write(Array[i] + " ");
}
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] >= 10 && Array[i] < 100)
    {
        count++;
    }
}
System.Console.WriteLine("Количество совпадений" + " " + count);
*/


//2 вариант

int GetCount(int[] Array, int MinLimit, int MaxLimit)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= MinLimit && Array[i] < MaxLimit)
        {
            count = count + 1;
        }
    }
    return count;

}
System.Console.WriteLine(GetCount(new int[] { 10, 15, 25, 45, 32, 66 }, 10, 30));

   // Array[i] = new Random().Next(0, 200);
