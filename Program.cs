// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Вывод надписи запроса ввода первого числа.
Console.Write ("Введите первое число ");
// Ввод в консоль первого числа.
int num1 = Convert.ToInt32(Console.ReadLine());
// Вывод надписи запроса ввода второго числа.
Console.Write ("Введите второе число ");
// Ввод в консоль второго числа.
int num2 = Convert.ToInt32(Console.ReadLine());
// Ввод надписи запроса третьего числа
Console.Write ("Введите третье число ");
// Ввод в консоль третье число.
int num3 = Convert.ToInt32(Console.ReadLine());
// Вывод максимального из трёх чисел.
Console.Write ("max = ");
// Переменная, которой присваивается максимальное значение.
int max = num1;
// Условие сравнения трёх чисел между собой.
if (num2 > num1)
{
    if (num3 > num2)
    {
        Console.Write (max = num3);
    }
    else
    {
        Console.Write (max = num2);
    }
}
else
{
    if (num1 > num3)
    {
        Console.Write (max = num1);
    }
    else
    {
        Console.Write (max = num3);
    }
}