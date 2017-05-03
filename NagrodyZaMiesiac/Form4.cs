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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string _profil;

        public string profilName
        {
            get { return _profil; }
            set { _profil = value; }
        }

    }
}
