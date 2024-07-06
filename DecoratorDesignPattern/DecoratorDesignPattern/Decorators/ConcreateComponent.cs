using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class ConcreateComponent : BaseComponent
    {
        public override int Cost()
        {
            return 100;
        }
    }
}
