// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

Console.Write("Укажите размер массива n: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
Random rand = new Random();

for (int i = 0; i < n; i++)
{
a[i] = rand.Next(100,300);
Console.WriteLine("Значение элемента массива "+" = " + a[i]);
}

int count = 0;

for (int i = 0; i < n; i++)
{
if (a[i] % 2 != 0)
++count;
}
Console.WriteLine("Количество нечетных элементов: " + count.ToString());