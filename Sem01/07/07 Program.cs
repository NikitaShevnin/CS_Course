// 7.	Выяснить является ли число чётным.

System.Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
        if ((x % 2) == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число не чёное");
        }