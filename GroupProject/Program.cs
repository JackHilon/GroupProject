using System;

namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "We are all!";
            Console.WriteLine("Hello Oliver!");
            Console.WriteLine("Hello Oliver!");
            Console.WriteLine("Hello Oliver!");
            Console.WriteLine("Hello Oliver!");
            Console.WriteLine("Hello Jack's branch!");
            Console.WriteLine($"str {3 + 5} .....!");
            Console.WriteLine("Hello every one!");
            for(int i = 0; i < 100; i++){
                Console.WriteLine(i.ToString());
                Console.WriteLine(i.ToString());
            }
            var name = new NewClass("jlfjsd kjsdjlfjs kjsfklsjfd", 8);
            Console.WriteLine(name.GetName()); 

        }
    }
}
