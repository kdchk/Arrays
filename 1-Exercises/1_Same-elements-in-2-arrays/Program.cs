using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Same_elements_in_2_arrays
{
    class Program
    {
        /*Задача:
            Есть два целочисленных массива.
            Необходимо записать в третий массив одинаковые для обоих массивов элементы.
            Одинаковые элементы не должны повторяться больше одного раза. 
        */
        static void Main(string[] args)
        {
            //Задаем длинну исходных массивов
            int array1elements = 10;
            int array2elements = 10;

            //Создаем два массива
            int[] array1 = new int[array1elements];
            int[] array2 = new int[array2elements];

            //Заполняем массивы случайными данными
            Random random = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(0, array1.Length);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, array2.Length);
            }

            //Выводим исходные массивы на экран
            Console.WriteLine("---Первый массив---");
            foreach (int i in array1)
                Console.Write($"{i} ");

            Console.WriteLine("\n---Второй массив---");
            foreach (int i in array2)
                Console.Write($"{i} ");

            //Задаем длинну результирующего массива
            int array3elements = array1elements * array2elements;

            //Создаем результирующий массив
            int[] array3 = new int[array3elements];


            //Проверяем исходные массивы на одинаковые элементы и записываем результаты в результирующий массив
            int count = 0; 
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        int equal = 0;
                        for (int k = 0; k < count; k++)
                        {
                            if (array3[k] == array1[i])
                            {
                                equal++;
                            }
                        }
                        if (equal == 0)
                        {
                            array3[count] = array1[i];
                            count++;
                        }
                    }
                }
            }
            //Изменяем размер результирующего массива до количества найденных элементов
            Array.Resize(ref array3, count);

            //Выводим результат на экран
            Console.WriteLine("");
            Console.WriteLine("\n---Результирующий массив---");

            foreach (int i in array3)
                Console.Write($"{i} ");


            Console.ReadKey();

        }

    }
}
