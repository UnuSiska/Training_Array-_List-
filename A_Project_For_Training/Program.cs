using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Project_For_Training
{
    internal class Program
    {
        private void IteratingThroughArrays()
        {
            int[] array = {1, 2, 3, 4};
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Length - 1)
                {
                    break;
                }else Console.WriteLine(array[i]);
            }
            //Делал на сайте, ссылка: http://csharpbook.sakutin.ru/задачи-на-массивы/
        }
        private void AddingAndRemovingArrayElements()
        {
            //1 задание 
            /*void Task1()
            {
                int[] array = { 1, 2, 3, 4 };
                int valueToAdd = 10;
                int[] largerArray = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    largerArray[i] = array[i];
                }

                largerArray[array.Length] = valueToAdd;
                array = largerArray;

                foreach (int i in array)
                    Console.WriteLine(i);
            }*/


            //2 задание
            /*void Task2()
            {
                //int[] array = { 1, 2, 3, 4 };
                //int valueToAdd = 10;
                //int[] largerArray = new int[array.Length + 1];

                //for (int i = 1; i <= array.Length; i++)
                //{
                //    largerArray[i] = array[i - 1];
                //}

                //largerArray[0] = valueToAdd;
                //array = largerArray;
                //foreach (int i in array)
                //{
                //    Console.WriteLine(i);
                //}
            }*/


            //3 задание
            /*void Task3()
            {
                int[] array = { 1, 2, 3, 4 };
                int value = 111;
                int pos = 2;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == pos)
                    {
                        array[i] = value;
                    }
                    Console.WriteLine(array[i]);
                }
            }*/


            //4 задание
            /*void Task4()
            {
                int[] array = { 1, 2, 3, 4 };
                int[] smallerArray = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    smallerArray[i] = array[i];
                }

                array = smallerArray;
            }*/


            //5 задание
            /*void Task5()
            {
                int[] array = { 1, 2, 3, 4 };
                int[] smallerArray = new int[array.Length - 1];

                for (int i = 1; i <= smallerArray.Length; i++)
                {
                    smallerArray[i - 1] = array[i];
                }

                array = smallerArray;
                foreach (int i in array)
                    Console.WriteLine(i);
            }*/


            /*6 задание
            int[] array = { 1, 2, 3, 4, 5 }; // Исходный массив
            int indexToRemove = 3; // Индекс элемента, который мы хотим удалить

            // Создаем новый массив с длиной меньше на 1
            int[] newArray = new int[array.Length - 1];

            // Копируем элементы, пропуская индекс, который нужно удалить
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != indexToRemove) // Пропускаем элемент, который нужно удалить
                {
                    newArray[j] = array[i]; // Копируем элемент в новый массив
                    j++; // Увеличиваем индекс для нового массива
                }
            }

            // Теперь newArray содержит все элементы, кроме удаленного
            array = newArray; // Переназначаем массив, если необходимо

            // Вывод нового массива на экран
            Console.WriteLine(string.Join(", ", array));*/


            /* 7 задание
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[][] toMerge = { array1, array2 };

            int[] result = new int[array1.Length + array2.Length];

            for (int i = 0, j = 0; i < toMerge.Length; i++)
            {
                for (int k = 0; k < toMerge[i].Length; k++)
                {
                    result[j] = toMerge[i][k];
                    j++;
                }
            }*/
        }



        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddingAndRemovingArrayElements();
        }
    }
}
