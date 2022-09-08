// 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
string input = Console.ReadLine(); 
int number = int.Parse(input); 

for (int i = 2; i <= number; i = i + 2) 
Console.WriteLine(i);