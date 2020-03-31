using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numero = { 1, 2, 3, 4, 5 };

            int[] arrayInt = new int[10];

           
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = i + 1;
                //Console.WriteLine(arrayInt[i]);
            }

            foreach (int numeros in arrayInt)
            {
                Console.WriteLine(numeros);
            }


     
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
