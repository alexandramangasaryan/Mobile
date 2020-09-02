using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Nokia : Mobile
    {
        public override void calling()
        {
            Console.WriteLine("Nokia: To silence an incoming call, press the volume down key");
        }

        public override void camera()
        {
            Console.WriteLine("Nokia: Nokia Camera phone gives you the list " +
                "of all the latest and new Camera mobile phones manufactured by Nokia.");
        }
        public override void messaging()
        {
            Console.WriteLine("Nokia: you have a message");
        }
    }
    public class Nokia_X6:Nokia
    {
        public override void camera()
        {
            Console.WriteLine("Nokia X6: Nokia X6 is equipped with two rear cameras");
        }
    }
}
