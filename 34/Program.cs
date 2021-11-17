// Написать программу замену элементов массива на противоположные
int[] ReplacingArray(int index)
{
      int[] Array = new int[index];

      for (int i = 0; i < index; i++)
     {
       Array[i] = new Random().Next(-5, 10);
       System.Console.Write(Array[i] + " ");
       System.Console.WriteLine(" " + Array[i] * (-1));
     }
     return Array;
}
ReplacingArray(8);

