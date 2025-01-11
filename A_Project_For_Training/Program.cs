using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Project_For_Training
{
    internal class Program
    {
        //Сделать массив, полем класса, НЕ ЗАБУДЬ!!! ОЛУХ
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
            int[] array = { 1, 2, 3, 4 };
        }



        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddingAndRemovingArrayElements();
        }
    }
}
