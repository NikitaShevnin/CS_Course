// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("введите значение A");
double a=Convert.ToDouble(System.Console.ReadLine());
Console.WriteLine("Напишите в какую степень возводим значение А?");
double b=Convert.ToDouble(System.Console.ReadLine());

if(a>0)
Console.WriteLine("a в степени b=" + Math.Pow(a,b));
else System.Console.WriteLine("0 нельзя возвести в степень");
