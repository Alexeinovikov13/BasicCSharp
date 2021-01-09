using System;

namespace Classes_002
{
    class MyClass
    {
        MyClass my = null;
        private void Method()
        {
            Console.WriteLine("Вызов метода Method");
        }
        public void CallMethod()
        {
            my = new MyClass();
            my.Method();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            Console.WriteLine("Hello GitHub");
        }
    }
}
