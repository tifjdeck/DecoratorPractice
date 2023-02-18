using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget w) : base(w)
        {

        }
        override public void draw()
        {
            Console.WriteLine("I am a border decorator, holding a: ");
            base.draw();
        }
    }
}
