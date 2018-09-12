using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Class;
using System.Collections;
using System.Collections.Specialized;

namespace AddressBookClass
{
    [Serializable]
    public class AddressBook
    {
        public ArrayList Book { get; set; }

        //constructor to create the ArrayList
        public AddressBook()
        {
            Book = new ArrayList();
            
        }

        //Creates a simple output using the built-in ToString command, adding a new line for every Person class found in Book
        public override string ToString()
        {
            string outputString = "";
            foreach(Person i in Book)
            {
                outputString += i + "\r\n";
                
            }
            return outputString;
        }
        

       
    }
}
