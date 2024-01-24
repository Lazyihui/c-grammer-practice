using System;

namespace Ex
{

    class HelloWorld
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
            Console.WriteLine("lenth:{0}", length);
            Console.WriteLine("width:{0}", width);

        }
    }
    class ExMain
    {
        static void Main()
        {
            HelloWorld he = new HelloWorld();
            he.Init();
            he.Display();
        }
    }
}
