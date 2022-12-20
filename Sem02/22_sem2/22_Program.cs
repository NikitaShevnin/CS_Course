// 22.	Программа проверяет пятизначное число на палиндромом.

// Осуществялем ввод с консоли
System.Console.WriteLine("Введите пятизначное число");
int n=Convert.ToInt32(Console.ReadLine());

// Проверяем является ли число 5-ти значниым
if (n>10000 && n<99999);
else System.Console.WriteLine("Вы ввели не пятизначное число");

// Узнаем начало 1 и Конец 1
int first_num1=n/10/10/10/10;
int last_num1=n%10;
// Узнаем начало 2 и Конец 2
int first_num2=n/10/10/10%10;
int last_num2=n/10%10;

// Выясняем является ли введнное число палиндромом
if (first_num1==last_num1 && first_num2==last_num2) System.Console.WriteLine("Поздравляем это число палиндром");
else System.Console.WriteLine("Это число не палиндром");