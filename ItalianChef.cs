using System;
using System.Collections.Generic;
using System.Text;

namespace Chef_super_sub_C
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes risotto");
        }
        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");
        }
    }
}
