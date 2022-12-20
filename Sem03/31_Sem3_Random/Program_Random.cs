// Сгенерировать 10 случайныйх чисел, показать кубы тех чисел которые заканчиваются
// на четную цифру

bool test (int a) 
{
 return a*a*a%10%2==0;
}


Random random=new Random(10);
for (int i=0;i<20;i++)
{
 int a=random.Next(1,20);
 int b=a;
 if (test (b))
    System.Console.WriteLine($"{a}, {b}");
}