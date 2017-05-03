using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NagrodyZaMiesiac
{
    public partial class Form3 : Form
    {
        private OleDbConnection bazaPolacz = new OleDbConnection();

        #region[zmienneDoArchiwum]

        //poleNAZWA

        private string _archiwum1;

        public string textArchiwum1
        {
            get { return _archiwum1; }
            set { _archiwum1 = value; }
        }
            

        private string _archiwum2;

        public string textArchiwum2
        {
            get { return _archiwum2; }
            set { _archiwum2 = value; }

        }

        private string _archiwum3;

        public string textArchiwum3
        {
            get { return _archiwum3; }
            set { _archiwum3 = value; }
        }

        private string _archiwum4;

        public string textArchiwum4
        {
            get { return _archiwum4; }
            set { _archiwum4 = value; }
        }

        private string _archiwum5;

        public string textArchiwum5
        {
            get { return _archiwum5; }
            set { _archiwum5 = value; }
        }

        private string _archiwum6;

        public string textArchiwum6
        {
            get { return _archiwum6; }
            set { _archiwum6 = value; }
        }

        private string _archiwum7;

        public string textArchiwum7
        {
            get { return _archiwum7; }
            set { _archiwum7 = value; }
        }
        private string _archiwum8;

        public string textArchiwum8
        {
            get { return _archiwum8; }
            set { _archiwum8 = value; }
        }
        private string _archiwum9;

        public string textArchiwum9
        {
            get { return _archiwum9; }
            set { _archiwum9 = value; }
        }
        private string _archiwum0;

        public string textArchiwum0
        {
            get { return _archiwum0; }
            set { _archiwum0 = value; }
        }

        // poleKASA

        private string _archiwum1a;

        public string textArchiwum1a
        {
            get { return _archiwum1a; }
            set { _archiwum1a = value; }
        }


        private string _archiwum2a;

        public string textArchiwum2a
        {
            get { return _archiwum2a; }
            set { _archiwum2a = value; }

        }

        private string _archiwum3a;

        public string textArchiwum3a
        {
            get { return _archiwum3a; }
            set { _archiwum3a = value; }
        }

        private string _archiwum4a;

        public string textArchiwum4a
        {
            get { return _archiwum4a; }
            set { _archiwum4a = value; }
        }

        private string _archiwum5a;

        public string textArchiwum5a
        {
            get { return _archiwum5a; }
            set { _archiwum5a = value; }
        }

        private string _archiwum6a;

        public string textArchiwum6a
        {
            get { return _archiwum6a; }
            set { _archiwum6a = value; }
        }

        private string _archiwum7a;

        public string textArchiwum7a
        {
            get { return _archiwum7a; }
            set { _archiwum7a = value; }
        }
        private string _archiwum8a;

        public string textArchiwum8a
        {
            get { return _archiwum8a; }
            set { _archiwum8a = value; }
        }
        private string _archiwum9a;

        public string textArchiwum9a
        {
            get { return _archiwum9a; }
            set { _archiwum9a = value; }
        }
        private string _archiwum0a;

        public string textArchiwum0a
        {
            get { return _archiwum0a; }
            set { _archiwum0a = value; }
        }

        //polaCHECKBOX

        private bool _archiwum1b;

        public bool textArchiwum1b
        {
            get { return _archiwum1b; }
            set { _archiwum1b = value; }
        }


        private bool _archiwum2b;

        public bool textArchiwum2b
        {
            get { return _archiwum2b; }
            set { _archiwum2b = value; }

        }

        private bool _archiwum3b;

        public bool textArchiwum3b
        {
            get { return _archiwum3b; }
            set { _archiwum3b = value; }
        }

        private bool _archiwum4b;

        public bool textArchiwum4b
        {
            get { return _archiwum4b; }
            set { _archiwum4b = value; }
        }

        private bool _archiwum5b;

        public bool textArchiwum5b
        {
            get { return _archiwum5b; }
            set { _archiwum5b = value; }
        }

        private bool _archiwum6b;

        public bool textArchiwum6b
        {
            get { return _archiwum6b; }
            set { _archiwum6b = value; }
        }

        private bool _archiwum7b;

        public bool textArchiwum7b
        {
            get { return _archiwum7b; }
            set { _archiwum7b = value; }
        }
        private bool _archiwum8b;

        public bool textArchiwum8b
        {
            get { return _archiwum8b; }
            set { _archiwum8b = value; }
        }
        private bool _archiwum9b;

        public bool textArchiwum9b
        {
            get { return _archiwum9b; }
            set { _archiwum9b = value; }
        }
        private bool _archiwum0b;

        public bool textArchiwum0b
        {
            get { return _archiwum0b; }
            set { _archiwum0b = value; }
        }

        //poleDATA i suma dnia

        private string _archiwum1c;

        public string textArchiwum1c
        {
            get { return _archiwum1c; }
            set { _archiwum1c = value; }
        }

        private string _archiwum1d;

        public string textArchiwum1d
        {
            get { return _archiwum1d; }
            set { _archiwum1d = value; }
        }

        #endregion

        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;

            //poleNAZWA
            listaBox3_1.Text = _archiwum1;
            listaBox3_2.Text = _archiwum2;
            listaBox3_3.Text = _archiwum3;
            listaBox3_4.Text = _archiwum4;
            listaBox3_5.Text = _archiwum5;
            listaBox3_6.Text = _archiwum6;
            listaBox3_7.Text = _archiwum7;
            listaBox3_8.Text = _archiwum8;
            listaBox3_9.Text = _archiwum9;
            listaBox3_0.Text = _archiwum0;

            // poleKASA
            kasaBox3_1.Text = _archiwum1a;
            kasaBox3_2.Text = _archiwum2a;
            kasaBox3_3.Text = _archiwum3a;
            kasaBox3_4.Text = _archiwum4a;
            kasaBox3_5.Text = _archiwum5a;
            kasaBox3_6.Text = _archiwum6a;
            kasaBox3_7.Text = _archiwum7a;
            kasaBox3_8.Text = _archiwum8a;
            kasaBox3_9.Text = _archiwum9a;
            kasaBox3_0.Text = _archiwum0a;

            //polaCHECKBOX
            checkBox3_1.Checked = _archiwum1b;
            checkBox3_2.Checked = _archiwum2b;
            checkBox3_3.Checked = _archiwum3b;
            checkBox3_4.Checked = _archiwum4b;
            checkBox3_5.Checked = _archiwum5b;
            checkBox3_6.Checked = _archiwum6b;
            checkBox3_7.Checked = _archiwum7b;
            checkBox3_8.Checked = _archiwum8b;
            checkBox3_9.Checked = _archiwum9b;
            checkBox3_0.Checked = _archiwum0b;

            //// poleKASA i suma dzień
            dateLabel3.Text = _archiwum1c;
            dzienBox3.Text = _archiwum1d;
        }

        private void zamknijButton3_Click(object sender, EventArgs e)
        {
            bazaPolacz.Close();

            this.Close();
        }


    }
}
