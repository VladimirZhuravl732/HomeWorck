// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д

int[] Array = new int[10];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 11);
    System.Console.Write(Array[i] + " ");
}
System.Console.WriteLine();
int j = Array.Length - 1;
for (int i = 0; i < Array.Length / 2; i++)
{
    System.Console.WriteLine("Result" + " " + Array[i] * Array[j]);
    j--;
}




