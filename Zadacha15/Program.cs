//Задача 15: Напишите программу, которая принимает на вход цифру, о
// бозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
// 7 -> да 
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели 1-7: ");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num >7)
  {
    Console.Write("Не верно введено число");
    return;
  }
if (num == 6 || num == 7) {
  Console.Write("Да");
}
else {
  Console.Write("Нет");
}
  