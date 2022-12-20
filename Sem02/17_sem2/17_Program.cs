// 17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

System.Console.WriteLine("введите число обозначающее день недели");
int n=Convert.ToInt32(Console.ReadLine());
int Mon=1;
int Tue=2;
int Wed=3;
int Thur=4;
int fri=5;
int sat=6;
int sun=7;
    if (n==sat || n==sun)System.Console.WriteLine("это выходной день");
    else System.Console.WriteLine("Это будний день");