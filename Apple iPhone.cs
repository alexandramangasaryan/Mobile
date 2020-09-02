using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Apple_iPhone : Mobile
    {
        public override void calling()
        {
            Console.WriteLine("iPhone: Start calling");
        }
        public override void camera()
        {
            Console.WriteLine("iPhone: say cheese");
        }
        public override void messaging()
        {
            Console.WriteLine("iPhone: you have a message");
        }
    }
    public class IPhone9:Apple_iPhone
    {
        public override void calling()
        {
            Console.WriteLine("iPhone9: Incoming call");
        }
    }
}
