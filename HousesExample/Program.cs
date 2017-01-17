using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House House1 = new House();
            House1.Paint("Green");//Using methods from class
            //Console.WriteLine(House1.CurrentColor());
            House1.Paint("White");//Using methods from class
            //Console.WriteLine(House1.CurrentColor());

            House House2 = new House();
            House2.Paint("Yellow");
            Console.WriteLine(House1.CurrentColor());
            Console.WriteLine("This house has {0} paint", House1.CurrentColor());
            Console.WriteLine("This house has {0} paint", House2.CurrentColor());
        }
    }
}
