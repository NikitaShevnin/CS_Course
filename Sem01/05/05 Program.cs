// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Ввод числа a");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввод числа b");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввод числа c");
int c=Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
System.Console.WriteLine($"max is {max}");