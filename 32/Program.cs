// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

//1 способ
/*int[] Array = new int[8];

for (int i = 0; i <= Array.Length; i++)
{
    int result = new Random().Next(0, 2);
    System.Console.WriteLine(result);
}
*/
// 2 способ

int[] ArrayOneZero() // метод
{
    int[] Array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Array[i] = new Random().Next(0, 2);
    }
    return Array;
}

int[] A = ArrayOneZero();
for (int i = 0; i < 8; i++)
{
    System.Console.Write($"{A[i]} ");
}





