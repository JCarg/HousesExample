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
            House House1 = new House("Blue",4,1000,5);
            //House1.Paint("Green");//Using methods from class
            //Console.WriteLine(House1.CurrentColor());
            //House1.Paint("White");//Using methods from class
            //Console.WriteLine(House1.CurrentColor());

            House House2 = new House("Mahogany",18,100,30);
            //House2.Paint("Yellow");
            //Console.WriteLine(House1.CurrentColor());
            //Console.WriteLine("This house has {0} paint", House1.CurrentColor());
            //Console.WriteLine("This house has {0} paint", House2.CurrentColor());

            House1.DisplayHouseInfo();
            House2.DisplayHouseInfo();

        }
    }
}
