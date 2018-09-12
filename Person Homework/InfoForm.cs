using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Person_Class;

namespace Person_Homework
{
    public partial class InfoForm : Form
    {
        public InfoForm(Person personObj)
        {
            InitializeComponent();
            nameBox.Text = personObj.NameString();
            noteBox.Text = personObj.NoteOutput();
            foreach(string item in personObj.GetEmails())
            {
                emailBox.Items.Add(item);
                emailBox.SelectedIndex = 0;
            }
            foreach (KeyValuePair<string, object> i in personObj.GetAddresses())
            {
                addressBox.Items.Add(i.Key + ": " + i.Value);
                addressBox.SelectedIndex = 0;
            }
            foreach (KeyValuePair<string, string> i in personObj.GetNumbers())
            {
                phoneBox.Items.Add(i.Key + ": " + i.Value);
                phoneBox.SelectedIndex = 0;
            }
        }
    }
}
