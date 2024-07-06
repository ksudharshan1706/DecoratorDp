using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators.decoratorpatterns
{
   class ConcreateDecoratorA : Decorator
    {
        public ConcreateDecoratorA(BaseComponent baseComponent) : base(baseComponent)
        {

        }
        public override int Cost()
        {
            return base.Cost()+11;
        }
    }
}
