using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfPersons
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        public ItemForm(string text)
        {
            InitializeComponent();

            this.Text = text;
        }

        public ItemForm(string text, Person ob)
        {
            InitializeComponent();

            this.Text = text;

            firstName_textBox.Text = ob.FirstName;
            lastName_textBox.Text = ob.LastName;
            switch (ob.Gender.ToLower())
            {
                case "male":
                    male_radioButton.Checked = true;
                    break;
                case "female":
                    female_radioButton.Checked = true;
                    break;
                default:
                    other_radioButton.Checked = true;
                    break;
            }
            dateTimePicker1.Value = ob.DateBirth;
        }

        public Person GetPerson()
        {
            string gender = male_radioButton.Checked ? "Male" : (female_radioButton.Checked ? "Female" : "Other");
            return new Person(firstName_textBox.Text, lastName_textBox.Text, dateTimePicker1.Value, gender);
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(firstName_textBox.Text) || string.IsNullOrEmpty(lastName_textBox.Text) ||
                (!female_radioButton.Checked && !male_radioButton.Checked && !other_radioButton.Checked))
            {
                MessageBox.Show("All fields must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
