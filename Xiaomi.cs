using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Xiaomi : Mobile
    {
        public override void calling()
        {
            Console.WriteLine("Xiaomi: Please answer the phone");
        }

        public override void camera()
        {
            Console.WriteLine("Xiaomi: Smile, I am taking a picture");
        }
    }
    
    public class Xiaomi_Note9S:Xiaomi
    {
        public void music()
        {
            Console.WriteLine("Xiaomi Note9S: For listening music turn it on");
        }
        public override void messaging()
        {
            Console.WriteLine("Xiaomi Note9S: you have a message");
        }
    }
}
