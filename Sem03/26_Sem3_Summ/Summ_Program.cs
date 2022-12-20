// Найти сумму чисел от 1 до А

Console.WriteLine("Введите диапазон для расчета");
int a=Convert.ToInt32(System.Console.ReadLine());
int n=1;
int sum = 0;

bool Check(int n)
{
if (n<=a) return true; else return false;
}

while (Check (n))
{
sum=sum+n;
n++;
}
Console.WriteLine(sum);
