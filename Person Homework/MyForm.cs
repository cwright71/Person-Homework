using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Person_Class;
using System.Collections;
using AddressBookClass;


namespace Person_Homework
{
    public partial class MyForm : Form
    {
        //creates a new addressbook object
       AddressBook myAddressBook = new AddressBook();
        public MyForm()
        {
            InitializeComponent();
            //sets bools to check status of serialization
            bool serialBool = false;
            Type addBookType = myAddressBook.GetType();
            serialBool = addBookType.IsSerializable;

            
            
            //checks serialization. If not serialized, fills out address book and serializes, then fills form. If not serializable, displays that it is not serializable.
            if (serialBool == true)
            {
                try
                {
                    myAddressBook = SerialRead(myAddressBook);
                    statusBox.Text = "File read and successfully deserialized...";

                    
                }
                catch
                {
                    statusBox.Text = "Object is serializable, but is currently not serialized";
                    statusBox.Text = "Populating address book, and serializing...";
                    Populate(myAddressBook);
                    SerialWrite(myAddressBook);
                }
                
                foreach(Person entry in myAddressBook.Book)
                {
                    ListViewItem lvi = new ListViewItem(entry.NameString());
                    lvi.SubItems.Add(entry.FirstNumberString());
                    lvi.SubItems.Add(entry.GetCity());
                    lvi.SubItems.Add(entry.FirstEmailString());
                    ContactsListView.Items.Add(lvi);
                    
                }
            }

            else
            {
                statusBox.Text = "Object is not serializable";
            }

        }

        static AddressBook SerialRead(AddressBook addBook)
        {
            IFormatter iBin = new BinaryFormatter();
            Stream streamobj = new FileStream(@".\AddressBook.info", FileMode.Open, FileAccess.Read, FileShare.None);
            addBook = (AddressBook)iBin.Deserialize(streamobj);
            streamobj.Close();
            return addBook;
        }

        static void SerialWrite(AddressBook addBook)
        {
            IFormatter iBin = new BinaryFormatter();
            Stream streamobj = new FileStream(@".\AddressBook.info", FileMode.Create, FileAccess.Write, FileShare.None);

            iBin.Serialize(streamobj, addBook);
            streamobj.Close();

        }

        static void Populate(AddressBook myBook)
        {

            Person bobPerson = new Person("Robert", "J", "Jones", "Consumer of fruit.");
            bobPerson.AddNumber("Work", "(407) 999-9999");
            bobPerson.AddNumber("Home", "(123) 456-789");
            bobPerson.AddAddress("Home", "1234 Ginsburg Street", "Lake Como", "FL", "32157", "Putnam County");
            bobPerson.AddAddress("Home2", "7484 Grape Road", "Bananaland", "FL", "36987", "Fruit County");
            bobPerson.AddEmail("rjjones@bananamail.com");
            bobPerson.AddEmail("fruitman@wambam.org");
            bobPerson.AddEmail("ThisJankyEmail@moreemails.com");
            myBook.Book.Add(bobPerson);

            Person jimPerson = new Person("Jim", "E", "Dean", "Makes sausages.");
            jimPerson.AddNumber("Cell", "(456) 789 1011");
            jimPerson.AddNumber("Home", "(987) 654 3210");
            jimPerson.AddAddress("Work", "2354 Over There Blvd.", "Hakuna Matata", "NY", "98765", "Worryless County");
            jimPerson.AddAddress("Home", "904587 Around The Corner", "Hakuna Matata", "NY", "98765", "Worryless County");
            jimPerson.AddAddress("More", "23423 more addresses can fit as well", "address city", "ST", "77777", "Some County");
            jimPerson.AddEmail("myemail@probablynotreal.com");
            jimPerson.AddEmail("jimsemail@definitelyrealemail.gov");
            myBook.Book.Add(jimPerson);

            Person aliciaPerson = new Person("Alicia", "A", "Licia", "No Note");
            aliciaPerson.AddNumber("Work", "(407) 123 4070");
            aliciaPerson.AddNumber("Numb2", "(521) 487 3620");
            aliciaPerson.AddNumber("More Numbers", "(234) 230 5832");
            aliciaPerson.AddNumber("Even More!", "(234) 577 7733");
            aliciaPerson.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson.AddEmail("lesleepyali@snoozetown.com");
            myBook.Book.Add(aliciaPerson);

            Person dogPerson = new Person("Dog", "D", "Woof", "Definitely not a dog.");
            dogPerson.AddNumber("Work", "(407) 684 6848");
            dogPerson.AddAddress("Home", "624 Masters Bed", "Bork Bork", "UT", "45769", "Home County");
            dogPerson.AddEmail("dogwoof@bork.com");
            myBook.Book.Add(dogPerson);

            Person aliciaPerson2 = new Person("Alicia2", "A2", "Licia2", "No Note");
            aliciaPerson2.AddNumber("Work", "(407) 123 4070");
            aliciaPerson2.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson2.AddEmail("lesleepyali@snoozetown.com2");
            myBook.Book.Add(aliciaPerson2);

            Person aliciaPerson3 = new Person("Alicia3", "A3", "Licia3", "No Note");
            aliciaPerson3.AddNumber("Work", "(407) 123 4070");
            aliciaPerson3.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson3.AddEmail("lesleepyali@snoozetown.com3");
            myBook.Book.Add(aliciaPerson3);

            Person aliciaPerson4 = new Person("Alicia4", "A4", "Licia4", "No Note");
            aliciaPerson4.AddNumber("Work", "(407) 123 4070");
            aliciaPerson4.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson4.AddEmail("lesleepyali@snoozetown.com4");
            myBook.Book.Add(aliciaPerson4);

            Person aliciaPerson5 = new Person("Alicia5", "A5", "Licia5", "No Note");
            aliciaPerson5.AddNumber("Work", "(407) 123 4070");
            aliciaPerson5.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson5.AddEmail("lesleepyali@snoozetown.com5");
            myBook.Book.Add(aliciaPerson5);

            Person aliciaPerson6 = new Person("Alicia6", "A6", "Licia6", "No Note");
            aliciaPerson6.AddNumber("Work", "(407) 123 4070");
            aliciaPerson6.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson6.AddEmail("lesleepyali@snoozetown.com6");
            myBook.Book.Add(aliciaPerson6);

            Person aliciaPerson7 = new Person("Alicia7", "A7", "Licia7", "No Note");
            aliciaPerson7.AddNumber("Work", "(407) 123 4070");
            aliciaPerson7.AddAddress("Home", "6974 Bordeme Road", "Le Sleep", "WA", "75739", "Sleeplandia");
            aliciaPerson7.AddEmail("lesleepyali@snoozetown.com7");
            myBook.Book.Add(aliciaPerson7);

            
        }
        
       

      
        //Allows you to double-click an entry to see more details and the full list of addresses, email addresses, and phone numbers. 
        private void ContactsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ContactsListView.SelectedItems !=null)
            {
                int myIndex = ContactsListView.FocusedItem.Index;


                InfoForm info = new InfoForm((Person)myAddressBook.Book[myIndex]);
                info.Show();
            }
        }

        private void ContactsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
