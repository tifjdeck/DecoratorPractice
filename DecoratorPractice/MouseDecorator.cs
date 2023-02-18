using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class MouseDecorator : Decorator
    {
        public MouseDecorator(IWidget w) : base(w)
        {

        }

        public override void draw()
        {
            Console.WriteLine("I am a mouse decorator, holding a: ");
            base.draw();
        }
    }
}
