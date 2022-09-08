// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа");
string input1 = Console.ReadLine(); 
int number1 = int.Parse(input1); 
string input2 = Console.ReadLine(); 
int number2 = int.Parse(input2); 

if (number1 > number2)
{
    Console.WriteLine($"Max = {number1}, Min = {number2}");
}
else 
{
    Console.WriteLine($"Max = {number2}, Min = {number1}");
}