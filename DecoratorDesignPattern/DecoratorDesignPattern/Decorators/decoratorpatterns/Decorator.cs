using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators.decoratorpatterns
{
    abstract class Decorator : BaseComponent
    {
        protected BaseComponent _baseComponent;
        public Decorator(BaseComponent baseComponent)
        {
            this._baseComponent = baseComponent;
        }

        public void setComponent(BaseComponent baseComponent)
        {
            this._baseComponent = baseComponent;
        }

        public override int Cost()
        {
            if (_baseComponent != null)
            {
                return this._baseComponent.Cost();
            }
            else
            {
                return 0;
            }
        }
    }
}
