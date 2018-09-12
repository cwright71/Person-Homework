using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Class;
using System.Collections;
using AddressBookClass;
using System.Windows.Forms;

namespace Person_Homework
{
    
    class Program
    {

        [STAThread]


        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //runs form
            Application.Run(new MyForm());

        }
    }
    
}
