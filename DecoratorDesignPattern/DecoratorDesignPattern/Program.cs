using DecoratorDesignPattern.Decorators;
using DecoratorDesignPattern.Decorators.decoratorpatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreateComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreateDecoratorA decorator1 = new ConcreateDecoratorA(simple);
            ConcreateDecoratorB decorator2 = new ConcreateDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
            Console.ReadLine();
        }
    }
}
