// 4.	По заданному с клавиатуры номеру дня недели вывести его название

System.Console.WriteLine("Осуществете ввод номера дня недели");
int n=Convert.ToInt32(Console.ReadLine());

if (n==1) System.Console.WriteLine("Понедельник");
if (n==2) System.Console.WriteLine("Вторник");
if (n==3) System.Console.WriteLine("Среда");
if (n==4) System.Console.WriteLine("Четверг");
if (n==5) System.Console.WriteLine("Пятница");
if (n==6) System.Console.WriteLine("Суббота");
if (n==7) System.Console.WriteLine("Воскресенье");
