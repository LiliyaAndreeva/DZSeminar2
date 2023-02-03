// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
// 782 -> 8 
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
if (num < 99 || num > 999)
{
  Console.Write("Не верно введено число ");
  return;
}
int result = ((num/10)%10);
Console.Write(($"{num} -> {result}"));