
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Хотел сделать возможность выбора вложения, при реализации которого была бы возможность задать все значения пользователю,
//  задать только числа, при этом случайно задается их количество и все задается случайно. Но из-за того, что наименование 
// переменных и функций(методов), совпадает... решил ограничится одним вариантом.

// class Program
// {

//     static void Main(string[] args)
//     {
//         char selection;
//         Console.WriteLine("Ввод чисел М и их количества пользователем. Для запуска укажите: 1");
//         Console.WriteLine("Ввод чисел М в количестве заданном программой. Для запуска укажите: 2");
//         Console.WriteLine("Ввод случайных значений. Для запуска укажите: 3");

//         selection = Convert.ToChar(Console.ReadLine());



//         switch (selection)
//         {
//             case '1':
//                     // Console.WriteLine("Задайте количество вводимых чисел: ");
//                     int numbr = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine($"Ввeдите {numbr} положительных и отрицательных чисел");
//                     int [] numbers1 = new int [numbr];
                
//                     Console.WriteLine(creatArray(numbers1));

                    
//                         {
//                         for (int i = 0; i < array.Length; i++)
//                             {
                                
//                                 Console.WriteLine($"Введите число: ");
//                                 array[i] = Convert.ToInt32(Console.ReadLine());
                                
//                             }
//                             return array;
//                         }

//                     Console.WriteLine($"\nВ массиве {plusum1(numbers1)} положительных чисел");

//                     int plusum1(int [] array)
//                     {
//                         int count = 0;
//                         foreach (int a in array)
//                         {
//                             if (a > 0) count++;
//                         }
//                     return count;
//                     }
//                     break;
//             case '2':
//                     int M = new Random().Next(1,10);
//                     Console.WriteLine($"Ввeдите {M} положительных и отрицательных чисел");
//                     int [] numbers2 = new int [M];

//                     Console.WriteLine(creatArray(numbers2));

//                     int[] creatArray(int [] array)
//                         {
//                         for (int i = 0; i < array.Length; i++)
//                             {
                                
//                                 Console.WriteLine($"Введите число: ");
//                                 array[i] = Convert.ToInt32(Console.ReadLine());
//                             }
//                             return array;
//                         }

//                     Console.WriteLine($"\nВ массиве {plusum2(numbers2)} положительных чисел");

//                     int plusum2(int [] array)
//                     {
//                         int count = 0;
//                         foreach (int a in array)
//                         {
//                             if (a > 0) count++;
//                         }
//                     return count;
//                     }
//             break;

//              case '3':

//                     int m = new Random().Next(1,10);
//                     Console.WriteLine($"Ввeдите {m} положительных и отрицательных чисел");
//                     int [] array = new int [m];
//                     int length = m;
//                     int index = 0;
//                     Console.Write("[ ");
//                         while (index < length)
//                             {
//                                 array[index] = new Random().Next(-10, m);         
//                                Console.Write($"{array[index]}, ");
                               
//                                index++;
//                             }
//                     Console.Write("]");        
//                     Console.Write(" <- Массив чисел ");
//                     Console.WriteLine($"\nВ массиве {plusum3(array)} положительных чисел");

//                         int plusum3(int [] array)
//                         {
//                             int count = 0;
//                             foreach (int a in array)
//                             {
//                                 if (a > 0) count++;
//                             }
//                         return count;
//                         }
//                     break;

//             default:
//                 Console.WriteLine("Вы ввели неверный символ. Для для запуска программы введите 1, 2 или 3");
//                 Console.ReadKey();
//                 break;
//         }
//     }
// }

                    int m = new Random().Next(1,10);
                    Console.WriteLine($"Ввeдите {m} положительных и отрицательных чисел");
                    int [] array = new int [m];
                    int length = m;
                    int index = 0;
                    Console.Write("[ ");
                        while (index < length)
                            {
                                array[index] = new Random().Next(-10, m);         
                               Console.Write($"{array[index]}, ");
                               
                               index++;
                            }
                    Console.Write("]");        
                    Console.Write(" <- Массив чисел ");
                    Console.WriteLine($"\nВ массиве {plusum3(array)} положительных чисел");

                        int plusum3(int [] array)
                        {
                            int count = 0;
                            foreach (int a in array)
                            {
                                if (a > 0) count++;
                            }
                        return count;
                        }