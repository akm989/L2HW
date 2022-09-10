// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:  ");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int number2 =  int.Parse(Console.ReadLine());
int max = 0;
int min =0;

if (number1 < number2)
{
    max = number2;
    min = number1;
}

else
{
    max = number1;
    min = number2;
}

Console.WriteLine($"Наибольшее число это = {max}, Наименьшее число это {min}");
