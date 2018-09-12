using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Person_Class
{
    [Serializable]
    public class Person
    {
        //Setting variables for Name, notes, the dictionary of numbers, addresses, and the list of email addresses. 
        private string firstName, middleName, lastName, note;
        private Dictionary<string, string> numberList = new Dictionary<string, string>();
        private Dictionary<string, object> addressList = new Dictionary<string, object>();
        private List<string> emailList = new List<string>();
        private string city;


        //constructor setting first, last, and middle name, along with note. 
        public Person(string fName, string mName, string lName, string nte)
            {
                
                firstName = fName;
                lastName = lName;
                middleName = mName;
                note = nte;
            }
       
        //simple function to add a new phone number to numberList
        public void AddNumber(string numType, string numValue)
        {
            numberList.Add(numType, numValue);
        }
        //simple function to add a new address to addressList
        public void AddAddress(string addType, string street, string city, string state, string zip, string county)
        {
            Address tempAddress = new Address(street, city, state, zip, county);
            addressList.Add(addType,tempAddress);
        }
        //simple function to add a new email to emailList
        public void AddEmail(string email)
        {
            emailList.Add(email);
        }
       
        //overriding ToString to create a simple output containing all the information for the Person entry
        public override string ToString()
        {
            string outputString = lastName + ", " + firstName + " " + middleName + "      " + numberList.First().Value.ToString() + "      " + addressList.First().Value.ToString() + "      " + emailList[0].ToString();
            return outputString;
            
        }

        //Combines the person's full name into a "last, first middle" output
        public string NameString()
        {
            string outputString = lastName + ", " + firstName + " " + middleName;
            return outputString;
        }

        //the next 3 strings set a variable to contain the first entry in each list for display.
        public string FirstAddressString()
        {
            string outputString = addressList.First().Value.ToString();
            return outputString;
        }

        public string FirstNumberString()
        {
            string outputString = numberList.First().Value.ToString();
            return outputString;
        }

        public string FirstEmailString()
        {
            string outputString = emailList[0].ToString();
            return outputString;
        }

        //output for the note variable
        public string NoteOutput()
        {
            string outputString = note;
            return outputString;
        }

        //gets the city from an addressList entry to output it by itself
        public string GetCity()
        {
            string outputString = ((Address)addressList.First().Value).CityString();
            return outputString;
        }
        //next 3 returns the full list of the email/phone number/address lists/dictionaries
        public List<string> GetEmails()
        {
            List<string> templist = new List<string>(emailList);

            return templist;
        }
        public Dictionary<string, string> GetNumbers()
        {
            Dictionary<string, string> tempNums = new Dictionary<string, string>(numberList);
            return tempNums;
        }
        public Dictionary<string, object> GetAddresses()
        {
            Dictionary<string, object> tempAdds = new Dictionary<string, object>(addressList);
            return tempAdds;
        }

    }
    [Serializable]
    //a separate class for address was created to create a dictionary of objects.
    public class Address
    {
        private string street, city, state, zip, county;
        public Address(string streetInput, string cityInput, string stateInput, string zipInput, string countyInput)
        {
            street = streetInput;
            city = cityInput;
            state = stateInput;
            zip = zipInput;
            county = countyInput;
        }
        public string CityString()
        {
            string outputString = city;
            return outputString;
        }
        public override string ToString()
        {
            return street + " " + city + ", " + state + " " + zip + " " + county;
        }
    }
        
}
