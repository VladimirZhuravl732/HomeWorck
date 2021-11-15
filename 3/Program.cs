// По заданному номеру дня недели вывести его название

System.Console.WriteLine("Введите номер дня недели");
string day = Console.ReadLine();
int DayWeek = Convert.ToInt32(day);

if (DayWeek == 1) { System.Console.WriteLine("Понедельник"); }
if (DayWeek == 2) { System.Console.WriteLine("Вторник"); }
if (DayWeek == 3) { System.Console.WriteLine("Среда"); }
if (DayWeek == 4) { System.Console.WriteLine("Четверг"); }
if (DayWeek == 5) { System.Console.WriteLine("Пятница"); }
if (DayWeek == 6) { System.Console.WriteLine("Суббота"); }
if (DayWeek == 7) { System.Console.WriteLine("Воскресенье"); }