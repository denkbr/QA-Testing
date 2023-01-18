// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < array.Length; i++)
{
        Console.Write($"{array[i]} ");

            if (array[i] % 2 == 0) count++;
}
Console.WriteLine();
System.Console.WriteLine($"Количество чётных элементов массива: {count}");