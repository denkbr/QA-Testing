// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
Console.Write("[ ");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}
Console.Write("]");
Console.WriteLine(" <- Массив чисел ");
int sum1 = 0;
int sum2 = 0;
for (int j = 1; j < array.Length; j+=2)
{
        if (j % 2 == 0)
                  sum1 = sum1 + array[j];
                else
                  sum2 = sum2 + array[j];
}
Console.WriteLine();
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {sum2} ");