// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

class Program
{
    static void Main(string[] args)
    {
        char selection;
        Console.WriteLine("Ввод элементов массива вручную. Для запуска укажите: 1");
        Console.WriteLine("Ввод элементов массива случайными числами. Для запуска укажите: 2");

        selection = Convert.ToChar(Console.ReadLine());

        switch (selection)
        {
            case '1':
                Console.Write("Введите количество элементов массива: ");
                int elementsCount = int.Parse(Console.ReadLine());
                int[] myArray = new int[elementsCount];

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"\nВвод элемента массива {i}: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nВывод массива: ");

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i]);
                }
//              break;
            Console.ReadKey();
                break;

            case '2':
                Console.Write("Введите количество элементов массива: ");
                void FillArray(int[] collect1)
                {
                    int length = collect1.Length;
                    int index = 0;
                    while (index < length)
                    {
                        collect1[index] = new Random().Next(1, elementsCount);

                        index++;
                    }
                }

                void PrintArray(int[] collect2) 
                {
                    int count = collect2.Length;
                    int position = 0;
                    while (position < count)
                    {
                        Console.Write(collect2[position]);
                        position++;    
                    }
                }
                elementsCount = int.Parse(Console.ReadLine());
                int[] array = new int[elementsCount];

                FillArray(array);
                PrintArray(array);
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Вы ввели неверный символ. Для выбора метода указания элементов массива напишите 1 или 2");
                Console.ReadKey();
                break;
        }

// функция  вывода массива на печать 
        void PrintArry(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            Console.Write("[");
            while(index < count)
            {
                Console.Write(coll[index]);
                index++;
                if (index < count)
                {
                Console.Write(", ");
                }
            }
        Console.Write("]");
        } 
// Так и не получилось понять как вывести на экран именно как в задании, т.е. [1, 2, 5, 7, 19].
    }
}

