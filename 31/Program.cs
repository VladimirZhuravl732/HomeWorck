// Задать массив из 8 элементов и вывести их на экран

int[] Array=new int [8];
for (int i =0; i<=Array.Length; i++)
{
    int result = new Random().Next(10,100);
    System.Console.WriteLine(result);
}