//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32 (Console.ReadLine());
int b = 2;
int count = 2;

while (count<=a)
{
    Console.WriteLine($"{b}");
    b=b+2;
    count=count+2;
}
