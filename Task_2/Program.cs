// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа");
string input1 = Console.ReadLine(); 
int a = int.Parse(input1); 
string input2 = Console.ReadLine(); 
int b = int.Parse(input2); 

if (a > b)
{
    Console.WriteLine($"Max = {a}");
}
else 
{
    Console.WriteLine($"Max = {b}");
}