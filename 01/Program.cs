// 1. С клавиатуры вводится целое число. Вывести квадрат числа 

System.Console.WriteLine("Введите число");
string? s = Console.ReadLine();
int a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(b);