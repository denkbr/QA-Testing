using Internal;
using System.Dynamic;
using System.ComponentModel;
using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// class Program
// {
//     static void Main(string[] args)
//     {
//         char selection;
//         Console.WriteLine("Ввод чисел М пользователем. Для запуска укажите: 1");
//         Console.WriteLine("Ввод чисел М из случайных значений. Для запуска укажите: 2");

//         selection = Convert.ToChar(Console.ReadLine());

//         switch (selection)
//         {
//             case '1':
                
                
                
                
                
                
//                 Console.Write("Введите количество элементов массива: ");
//                 int elementsCount = int.Parse(Console.ReadLine());
//                 int[] myArray = new int[elementsCount];

//                 for (int i = 0; i < myArray.Length; i++)
//                 {
//                     Console.Write($"\nВвод элемента массива {i}: ");
//                     myArray[i] = int.Parse(Console.ReadLine());
//                 }

//             Console.WriteLine("\nВывод массива: ");

//                 for (int i = 0; i < myArray.Length; i++)
//                 {
//                     Console.Write(myArray[i]);
//                 }

//             Console.ReadKey();
//                 break;

//             case '2':
                
                
                
                
//                 Console.Write("Введите количество элементов массива: ");
//                 int m = new Random().Next(1,10);

//                 void FillArray(int[] collect1)
//                 {
//                     int length = collect1.Length;
//                     int index = 0;
//                     while (index < length)
//                     {
//                         collect1[index] = new Random().Next(1, elementsCount);

//                         index++;
//                     }
//                 }

//                 void PrintArray(int[] collect2) 
//                 {
//                     int count = collect2.Length;
//                     int position = 0;
//                     while (position < count)
//                     {
//                         Console.Write(collect2[position]);
//                         position++;    
//                     }
//                 }
//                 elementsCount = int.Parse(Console.ReadLine());
//                 int[] array = new int[elementsCount];

//                 FillArray(array);
//                 PrintArray(array);
//                 Console.ReadKey();
//                 break;

//             default:
//                 Console.WriteLine("Вы ввели неверный символ. Для выбора метода указания элементов массива напишите 1 или 2");
//                 Console.ReadKey();
//                 break;
//         }
//     }
// }

int m = new Random().Next(1,10);
Console.WriteLine($"Ввудите {m} положительных и отрицательных чисел");
int [] numbers - new int [m];

Console.WriteLine(creatArray(numbers));
Console.WriteLine($"В массиве {plusum(numbers)} положительных чисел");

int [] creatArray (int [] array)
{
    for (int i = 0; i < ArrayConverter.Length; i++)
    {
        Console.WriteLine($"Введите число: ");
        array[i] = ConvertBinder.ToInt32(Console.ReadLine());
    }
    return array;
}

int plusum(int [] array)
{
    int count = 0;
    foreach (int a in array)
    {
        if (a > 0) count++;
    }
return count;
}