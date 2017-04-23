using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCart.Class1 debet = new CreditCart.Class1();
            CreditCart.Class1 credet = new CreditCart.Class1();
            Console.WriteLine("Your debet"+debet.debet);
            Console.WriteLine("Your credet" + credet.credet);
        }
    }
}
