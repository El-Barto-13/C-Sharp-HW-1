// C# Home Work 1

/*
 Задача 2: Напишите программу, 
 которая на вход принимает два числа и выдаёт, 
 какое число большее, а какое меньшее.
*/
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} больше {b}");
}
else
{
    Console.WriteLine($"{b} больше {a}");
}
*/

//_______________________________

/*
Задача 4: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третее число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)
{
    Console.WriteLine($"Максимальное число {a}");
}
else if (b >= a && b >= c)
{
    Console.WriteLine($"Максимальное число {b}");
}
else if (c >= a && c >= b)
{
    Console.WriteLine($"Максимальное число {c}");
}
*/

//_______________________________

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 2 == 0);
    if(num % 2 == 0)
    {
        Console.WriteLine($"Чётное число");
    }
    else
    {
        Console.WriteLine($"Не чётное число");
    }
    */

//_______________________________

/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

if(count == 1)
    {
        count +=1;
    }
    while (count <= num)
    {
        Console.WriteLine(count);
        count +=2;
    }
    */