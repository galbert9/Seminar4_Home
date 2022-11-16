// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());

int Method4(int a)
{
int sum = 0;

while (a > 0)
{
int d = a % 10;
a = a / 10;
sum = sum + d;

}
return sum;
}
 
// Для вызова этого метода требуется команда:
int res = Method4 (a);

Console.WriteLine(res);
Console.WriteLine(" ");






