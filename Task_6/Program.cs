// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string input = Console.ReadLine(); 
int number = int.Parse(input); 

int result = number % 2;


if (result == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else 
{
    Console.WriteLine($"Число {number} не является четным");
}