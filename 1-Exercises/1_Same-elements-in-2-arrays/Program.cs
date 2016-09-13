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
                array1[i] = random.Next(10);

            for (int i = 0; i < array2.Length; i++)
                array2[i] = random.Next(10);

            //Выводим исходные массивы на экран
            Console.WriteLine("---Первый массив---");
            foreach (int i in array1)
                Console.Write($"{i} ");

            Console.WriteLine("\n---Второй массив---");
            foreach (int i in array2)
                Console.Write($"{i} ");

            //Задаем длинну результирующего массива
            int array3elements;
            if (array1elements > array2elements)
                array3elements = array2elements;
            else
                array3elements = array1elements;

            //Создаем результирующий массив
            int[] array3 = new int[array3elements];

            //Проверяем исходные массивы на одинаковые элементы
            int sameElementsCount = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        //Проверяем результирующий массив на дупликаты одинаковых элементов
                        bool duplicateValues = false;

                        for (int k = 0; k < sameElementsCount; k++)
                        {
                            if (array3[k] == array1[i])
                            {
                                duplicateValues = true;
                                break;
                            }
                        }

                        //Записываем результаты в результирующий массив
                        if (duplicateValues == false)
                        {
                            array3[sameElementsCount] = array1[i];
                            sameElementsCount++;
                        }
                    }
                }
            }

            //Изменяем размер результирующего массива до количества найденных элементов
            Array.Resize(ref array3, sameElementsCount);

            //Выводим результат на экран
            Console.WriteLine("\n\n---Результирующий массив---");

            foreach (int i in array3)
                Console.Write($"{i} ");

            Console.ReadKey();
        }

    }
}
