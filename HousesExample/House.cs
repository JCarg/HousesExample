using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        //For any defined variable this. can be used to call on that instance
        //In the body fields are stored ex: Class house(rooms, colors)
        //Variables can be assigned values, but would have all instances with same value
        private string color;// Field
        private int rooms;// Access Modifier public should not be used for fields
        private int size;// Addding methods no longer need the keyword static
        private int doors;

        public void Paint(string color)
        {
            this.color = color;//.this goes back to the class to look for the variable and assigns it there.
        }

        public string CurrentColor()
        {
            return color;
        }
    }
}
