using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mobileIphone = new IPhone9();
            mobileIphone.Touch_ID();
            mobileIphone.messaging();
            Mobile mobileXiaomi = new Xiaomi_Note9S();
            mobileXiaomi.Touch_ID();
            mobileXiaomi.camera();
            mobileXiaomi.calling();
            Mobile mobileNokia = new Nokia_X6();
            mobileNokia.messaging();
            mobileNokia.Touch_ID();
            mobileNokia.camera();
            mobileNokia.calling();
        }
    }
}
