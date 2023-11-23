using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //*zad 1
            string name = "Alexandrina";
            int age = 17;

            if (age > 18) {
                Console.WriteLine("Пълнолетен");
            }
            else if (age < 18)
            {
                Console.WriteLine("Непълнолетен");
            }

            //*zad 2
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine(x + 1);
            }


            //*zad 3
            string[] colors = { "Green", "Blue", "Red" };
            colors[1] = "Yellow";
            foreach (string el in colors)
            {
                Console.WriteLine(el);
            }

            //*zad 4
            int[] myArray = new int[5];

            //*zad 5

            SayHello();
            SayHello("Alexandrina");
            Add(2, 4);
        }

        public static void SayHello()
        {
            Console.WriteLine("Аз съм функция");
        }
    
        public static void SayHello(string name)
        {
            Console.WriteLine("ZDR"+name);

        }
        public static int Add(int x, int y)
        {
            int c = x + y;
            return c;
        }
        

        
       

        
       
    
    }

}
