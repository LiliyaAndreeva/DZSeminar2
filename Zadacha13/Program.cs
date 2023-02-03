// Напишите программу, которая показывает 3
// цифру числа и сообщается если 3й цифры нет


Console.Clear();
Console.WriteLine("Введите число");  
string num = Convert.ToString (Console.ReadLine());  
int l = num.Length; 
if (l < 3)  
{  
Console.WriteLine ("у числа нет третьей цифры");   
 }  
else {  
string num3 = Convert.ToString(num[2]);  
Console.WriteLine ($"Третья цифра от {num} - > {num3}");  
}