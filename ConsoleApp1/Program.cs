using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива");
            byte size = byte.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rnd = new Random();
            for(int i=0;i<array.Length;i++)
            {
                array[i]=rnd.Next(-10,10);
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            int k = 0;
            //    for(int i=0;i<array.Length;i++)
            //{
            //  if  (array[i]>0) k++;
            //}
            ///*Console.WriteLine($"k={k}");*/
            foreach(int elem in array)
            {
                if (elem > 0) k++;
            }
            Console.WriteLine($"k={k}");
            Console.ReadKey();
        }
    }
}
