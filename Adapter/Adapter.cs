using System;

namespace Adapter
{
    public class Adapter : IExpectedInterface
    {
        private TargetClass _targetClass;
        public Adapter(TargetClass targetClass)
        {
            _targetClass = targetClass;
        }

        public void MethodA()
        {
            // Console.WriteLine(_targetClass.MethodB() +"");
            Console.WriteLine($"{_targetClass.MethodB()} with Adapter.MethodA() using Adapter Pattern");
        }
    }
}