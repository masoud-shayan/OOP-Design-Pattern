using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpectedInterface dependency = new Adapter(new TargetClass());
            dependency.MethodA();
        }
    }
}