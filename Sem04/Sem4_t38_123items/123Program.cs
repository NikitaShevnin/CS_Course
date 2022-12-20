// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

System.Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()); // вводим размер массива
int[] mas = new int[n]; // Обьявляем массив

Random r = new Random();
for (int i = 0; i < n; i++)
  {
  mas[i] = r.Next(1, 123);  //заполняем массив числами от 1 до 123
  }

System.Console.Write("вводим диапазон поиска от: ");
int A = int.Parse(Console.ReadLine());  
System.Console.Write("вводим клавиатуры диапазон до: ");
int B = int.Parse(Console.ReadLine());
int count = 0; //создаем счетчик
 
for (int i = 0; i < n; i++) 
  if ((mas[i] >= A) && (mas[i] <= B)) count++; // считаем кол-во элементов mas[i] в диапазоне
Console.WriteLine("Количество элементов в диапазоне " + count); //выводим на экран
