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
            bool a = OneThing(gro);
            Console.WriteLine(a);
            bool w = TwoThing(gro);
            Console.WriteLine(w);
        }

        public static bool OneThing(int gro)
        {
            int zero = 0;
            int fase = gro % 2;
            bool a = fase == zero;
            return a;

        }
        public static bool TwoThing(int gro)
        {
            for (int i=2;i<=(gro-1);i++)
            {
                if(gro%1==0)
                {
                    return false;
                }
            }

            return true;

        }

    }
}
