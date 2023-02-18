using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    public class Decorator : IWidget
    {
        private IWidget wid;

        public Decorator(IWidget w)
        {
            wid = w;
        }

        virtual public void draw()
        {
            wid.draw();
        }
    }
}
