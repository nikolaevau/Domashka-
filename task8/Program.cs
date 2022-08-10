// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа из диапазона от 1 до " + number + " : ");

for (int x = 1; x <= number; x++)       
if (x%2==0)    

Console.WriteLine(x);
