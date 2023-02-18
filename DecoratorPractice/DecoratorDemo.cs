using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField textField = new TextField(20, 30);
            ScrollDecorator scroll1 = new ScrollDecorator(textField);
            BorderDecorator border1 = new BorderDecorator(scroll1);
            MouseDecorator mouse1 = new MouseDecorator(border1);

            mouse1.draw();

            Console.ReadKey();
        }
    }
}
