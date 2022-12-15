// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

// Ввод данных через терминал
Console.WriteLine("введите значение a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b");
int b = Convert.ToInt32(Console.ReadLine());
// Сравнение заданных чисел и выявление максимального значения с помощью if/else
if (a>b) 
{
    Console.WriteLine($"max={a}");
}
else
{
    Console.WriteLine($"max={b}");
}