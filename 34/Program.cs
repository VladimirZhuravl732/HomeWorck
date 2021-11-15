// Написать программу замену элементов массива на противоположные
int[] Array = new int[10];
int result = 0;
//int res = 0;
for (int i = 0; i < Array.Length; i++)
{
    result = new Random().Next(-5, 10);
    System.Console.Write(result + " ");
    //res = result * (-1);
    System.Console.WriteLine(" " + result * (-1));
}


