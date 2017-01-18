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
        //Define fields up top. It does not have to be done within a program
        private string color;// Field
        private int rooms;// Access Modifier public should not be used for fields
        private int size;// Addding methods no longer need the keyword static
        private int doors;
        static private int avgHousePrice;//static means there is one copy for each template

        public House(string color, int rooms, int size, int doors)
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;

            
            
            // Constructors allow you to assign multiple values at once when setting up objects
            // The variable must match. Ex: Person Variable=new Kid(); Does not work.
            // Constructors are of the same species as objects
            // Constructors never return a value. Does not need to have parameters if hard coding is used in the body.
            // Constructors can share the same name, yet have different signatures.


        }

        public void DisplayHouseInfo()//When defining name for method must use Pascal Case.
        {
            Console.WriteLine("Color: " + color + "\nRooms: " + rooms + "\nSize: " + size + "\nDoors: " + doors);
        }

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
