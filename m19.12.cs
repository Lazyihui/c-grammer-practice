using System;

namespace Ex
{

    public class HelloWorld
    {
        double length;
        double width;

        public void Init()
        {
            length = 4.5;
            width = 3.5;
        }
        public void Display()
        {
            Console.WriteLine("lenth:{0}", length.ToString());
            Console.WriteLine("width:{0}", width);

        }
    }
    public class ExMain
    {
        public static void Main()
        {
            HelloWorld he = new HelloWorld();
            he.Display();
            Console.ReadLine();
        }
    }
}
