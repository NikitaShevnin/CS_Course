// 14.	С клавиатуры вводятся два числа a и b. 
// Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.WriteLine("Введите значение переменной а");
int a=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение переменной b");
int b=Convert.ToInt32(System.Console.ReadLine());

if (a%b==0)
{
    System.Console.WriteLine($"Значение переменной {a} кратно значению переменной {b}");
}
else
{
        System.Console.WriteLine(a%b);
}