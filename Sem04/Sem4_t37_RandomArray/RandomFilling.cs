int[] myArray = new int[5]; // обьявляется массив
Random rand = new Random(); // Обьявляем метод random
for (int x = 0; x < myArray.Length; x++) // вычисляем через for
{
 myArray[x] = rand.Next(100,300); // задаём диапазон
 Console.WriteLine("Значение элемента массива " + x + " = " + myArray[x]); // вывод
}