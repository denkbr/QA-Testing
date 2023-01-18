// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
using System;
Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write($"{Math.Round(array[i],3)} ");
}
Console.WriteLine();
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= max) max = array[i];
    if (min > array[i]) min = array[i];        
}
double result = Math.Round(max,3) - Math.Round(min,3);
Console.WriteLine(Math.Round(max,3)+ "-"+ Math.Round(min,3)+ "="+ Math.Round(result,3));