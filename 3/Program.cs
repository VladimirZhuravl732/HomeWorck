// По заданному номеру дня недели вывести его название

//1 способ

Console.WriteLine("Введите номер дня недели");
string day = Console.ReadLine();
int DayWeek = Convert.ToInt32(day);

if (DayWeek == 1) { Console.WriteLine("Понедельник"); }
if (DayWeek == 2) { Console.WriteLine("Вторник"); }
if (DayWeek == 3) { Console.WriteLine("Среда"); }
if (DayWeek == 4) { Console.WriteLine("Четверг"); }
if (DayWeek == 5) { Console.WriteLine("Пятница"); }
if (DayWeek == 6) { Console.WriteLine("Суббота"); }
if (DayWeek == 7) { Console.WriteLine("Воскресенье"); }
if (DayWeek >= 8) { Console.WriteLine("Такого дня недели нет"); }
if (DayWeek <= 0) { Console.WriteLine("Такого дня недели нет"); }


//2 способ
/*
string SearchDayWeek(int i)
{
    string DayWeek = string.Empty;
    if (i > 0 && i < 8)
    {
        string[] day = new string[] { " ", "Понедельник", "Втотрник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        DayWeek = $"Сегодня  { day[i]}";
    }
    else
    {
        DayWeek = $"Такого дня недели не существует.";
    }
    return DayWeek;
}

string result = SearchDayWeek(0);
System.Console.WriteLine(result);
*/

