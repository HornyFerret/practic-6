using System;

namespace practic_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int gro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше число : {gro}");
           
            OneThing(gro);
            TwoThing(gro);


        }

        public static void OneThing(int gro)
        {
            int zero = 0;
            int fase = gro % 2;
            if (fase == zero)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            return;

        }
        public static void TwoThing(int gro)
        {
            int zeroone = 10;
            if (gro>=zeroone)
            {
                Console.WriteLine("Число сложное");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
            return;
        }
    }
}
