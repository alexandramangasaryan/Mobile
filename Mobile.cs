using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public abstract class Mobile
    {
        public abstract void calling();
        public abstract void camera();
        public virtual void messaging()
        {
            Console.WriteLine("messaging");
        }
        public void Touch_ID()
        {
            Console.WriteLine("please leave your fingerprint");
        }
    }
}
