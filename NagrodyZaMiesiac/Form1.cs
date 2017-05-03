using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NagrodyZaMiesiac
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void otworzButton1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Beata")
            {
                Form2 f2 = new Form2();
                f2.profilName = "Beata";

                Hide();
                f2.ShowDialog();
                Close();
            }
            else { }

            if (comboBox1.Text == "Piotr")
            {
                Form2 f2 = new Form2();
                f2.profilName = "Piotr";


                Hide();
                f2.ShowDialog();
                Close();
            }
            else { }

            if (comboBox1.Text == "Izabela")
            {
                Form4 f4 = new Form4();
                f4.profilName = "Izabela";


                Hide();
                f4.ShowDialog();
                Close();
            }
            else { }

            if (comboBox1.Text == "Artur")
            {
                Form2 f4 = new Form2();
                f4.profilName = "Artur";


                Hide();
                f4.ShowDialog();
                Close();
            }
            else { }

        }

        private void zamknijButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
