// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите значение основания: число a");  
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите значение степени: число b");  
int b = Convert.ToInt32 (Console.ReadLine());

int Method4(int a, int b)
{
// int result = a ^ b;
int result = Convert.ToInt32(Math.Pow(a, b));
return result;
}

int res = Method4 (a, b);
Console.WriteLine(res);
Console.WriteLine(" ");