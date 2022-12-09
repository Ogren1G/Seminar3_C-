Console.WriteLine("Введите пятизначное число");

int n = int.Parse(Console.ReadLine());
int a = n / 10000;
int b = n % 10;
int c = (n % 10000) / 1000;
int d = (n % 100) / 10;

if(a == b && c == d)
{
    Console.WriteLine("Это палиндром!!!");
}
else
{
    Console.WriteLine("Это не палиндром :(");
}