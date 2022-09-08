// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа");
string input1 = Console.ReadLine(); 
int number1 = int.Parse(input1); 
string input2 = Console.ReadLine(); 
int number2 = int.Parse(input2); 
string input3 = Console.ReadLine(); 
int number3 = int.Parse(input3); 

int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max) 
{
    max = number3;
}
Console.WriteLine($"Max = {max}");