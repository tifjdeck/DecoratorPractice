using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(IWidget w) : base(w)
        {

        }

        override public void draw()
        {
            Console.WriteLine("I am a scroll decorator, holding a: ");
            base.draw();
        }
    }
}
