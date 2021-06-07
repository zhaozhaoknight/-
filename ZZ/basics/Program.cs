using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();



            Console.ReadKey();
        }

    }

    public class A
    {
        public A()
        {
            Asd();
        }
        public virtual void Asd() { }
    }
    public class B : A
    {
        int x = 1; int y;
        public B()
        {
            y = 2;
        }
        public override void Asd()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
    }
}
