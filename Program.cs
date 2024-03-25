//dz4 Функции
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// Пример:
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]
// void Main()
    // {
        while (true) // Бесконечный цикл
        {
            Console.WriteLine("Введите целое число (или 'q' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("[STOP]");
                break; // Выход из цикла при вводе "q"
            }
            else
            {
                int number;
                if (int.TryParse(input, out number)) // Попытка преобразования строки в целое число
                {
                    int sum = CheckNumDigits(number);
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("[STOP]");
                        break; 
                    }
                    // else
                    // {
                    //     Console.WriteLine("Сумма цифр числа нечетная.");
                    // }
                }
                else
                {
                    Console.WriteLine("Ошибка! Не удалось преобразовать введенное значение в целое число.");
                }
            }
        }
    // }

    static int CheckNumDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10; // Получаем последнюю цифру числа и добавляем ее к сумме
            num /= 10; // Удаляем последнюю цифру числа
        }
        return sum;
     }


// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// // Пример:
// [344 452 341 125] => 2

// int[] CreateArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++) //or i<n, т.к.в n задаем количество элементов массива
//     {
//         array[i] = new Random().Next(min, max + 1); //задаем случайное число в диапазоне от min до （max+1), таков метод. 
//                                                     //Простой max даст предпоследнее число в диапазоне/ НАпример, 8 а не 9.
//     }
//     return array; //метод должен вернуть массив
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// //запрашиваем длину массива

// int[] arr = CreateArray(size, 100, 999);
// PrintArray(arr);

// int CountEven (int[] array) //считает четные элементы массива
// {
//     int count =0;
// for (int i=0; i<array.Length;i++)
// {
//     if ( array[i]%2==0)
//     {
//         count=count+1;
//     }
// }
// return count;
// }

// System.Console.WriteLine(CountEven(arr));


// // Задача 3: Напишите программу, которая перевернёт
// // одномерный массив (первый элемент станет
// // последним, второй – предпоследним и т.д.)
// // // Пример:
// // [1 3 5 6 7 8] => [8 7 6 5 3 1]

// int[] CreateArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++) //or i<n, т.к.в n задаем количество элементов массива
//     {
//         array[i] = new Random().Next(min, max + 1); //задаем случайное число в диапазоне от min до （max+1), таков метод. 
//                                                     //Простой max даст предпоследнее число в диапазоне/ Например, 8 а не 9.
//     }
//     return array; //метод должен вернуть массив
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, min, max);
// PrintArray(arr);

// //int[] arr2 = Enumerable.Reverse(arr).ToArray(); //вариант переворота методом Enumerable.Reverse(array)
// int[] ReverseArray(int [] array)
// {
//  int i=0;
//   int n=array.Length;
//   int tmp;
//  int[] arr2 = new int[n];
//      for (i=0;i<n;i++)
//     {
//         tmp = array[n-1-i];
//         arr2 [i]= tmp;

//        }

//     return arr2;
// }

// PrintArray(ReverseArray (arr));