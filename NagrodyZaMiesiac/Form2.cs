using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NagrodyZaMiesiac
{

    //ZABLOKOWAĆ MOZLIWOŚĆ PISANIA LITER W OKIENKACH KASA ----- zrobione
    //na wpisywanie cyfr z klawaitury - Event (ma dodawac w realu) + wrzucanie wpisanych wartości do zmiennych float ----- zrobione/inaczej(po wpisaniu robi 0,00 ale po zaznaczeniu thick wczytuje wartosc)
    // jesli nie bedzie mzoliwości zapisu pól [kasa] to bedzie problem z wczytaniem archiwum - ROZWIĄZANE (patrz wczytanie dnia jesli wpis istnieje)
    //dodać pole gdzie bedzie wrzucana ostatnia wartość nagrody za miesiąc ----- ZROBIONE(testować)
    //zmienić miejsce przycisków - zapis w szczególności ----- ZROBIONE(testować)

    public partial class Form2 : Form

    {

        private OleDbConnection DatabaseConnect = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();

            DatabaseConnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Crow\Desktop\C#\mojeNagrody.accdb;
Persist Security Info=False;";

            DatabaseConnect.Close();
        }

        #region VARIABLES

        private string _profil;

        public string profilName
        {
            get { return _profil; }
            set { _profil = value; }
        }
        private string float1, float2, float3, float4, float5, float6, float7, float8, float9, float0, datecheck1, datecheck2, monthlyAward;
        private double digit1, digit2, digit3, digit4, digit5, digit6, digit7, digit8, digit9, digit0, dailyValue, monthlyValue;
        private bool boolean1, boolean2, boolean3, boolean4, boolean5, boolean6, boolean7, boolean8, boolean9, boolean0;
        #endregion

        #region VALIDATING and CHARS (KasaBOX)

        //validating to double, digits and comma in the boxes only (Validating/KeypPress)

        //kasa1
        private void kasaBox2_1_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_1.Text, out digit1))
            {
                if (kasaBox2_1.Text.IndexOf(',') != -1 && kasaBox2_1.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_1.Focus();
                }
                else
                    kasaBox2_1.Text = String.Format("{0:N2}", digit1);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_1.Focus();
            }
        }
        
        private void kasaBox2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa2
        private void kasaBox2_2_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_2.Text, out digit2))
            {
                if (kasaBox2_2.Text.IndexOf(',') != -1 && kasaBox2_2.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_2.Focus();
                }
                else
                    kasaBox2_2.Text = String.Format("{0:N2}", digit2);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_2.Focus();
            }
        }

        private void kasaBox2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa3
        private void kasaBox2_3_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_3.Text, out digit3))
            {
                if (kasaBox2_3.Text.IndexOf(',') != -1 && kasaBox2_3.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_3.Focus();
                }
                else
                    kasaBox2_3.Text = String.Format("{0:N2}", digit3);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_3.Focus();
            }
        }
    

        private void kasaBox2_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa4
        private void kasaBox2_4_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_4.Text, out digit4))
            {
                if (kasaBox2_4.Text.IndexOf(',') != -1 && kasaBox2_4.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_4.Focus();
                }
                else
                    kasaBox2_4.Text = String.Format("{0:N2}", digit4);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_4.Focus();
            }
        }

        private void kasaBox2_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa5
        private void kasaBox2_5_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_5.Text, out digit5))
            {
                if (kasaBox2_5.Text.IndexOf(',') != -1 && kasaBox2_5.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_5.Focus();
                }
                else
                    kasaBox2_5.Text = String.Format("{0:N2}", digit5);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_5.Focus();
            }
        }

        private void kasaBox2_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa6
        private void kasaBox2_6_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_6.Text, out digit6))
            {
                if (kasaBox2_6.Text.IndexOf(',') != -1 && kasaBox2_6.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_6.Focus();
                }
                else
                    kasaBox2_6.Text = String.Format("{0:N2}", digit6);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_6.Focus();
            }
        }

        private void kasaBox2_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa7
        private void kasaBox2_7_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_7.Text, out digit7))
            {
                if (kasaBox2_7.Text.IndexOf(',') != -1 && kasaBox2_7.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_7.Focus();
                }
                else
                    kasaBox2_7.Text = String.Format("{0:N2}", digit7);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_7.Focus();
            }
        }

        private void kasaBox2_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa8
        private void kasaBox2_8_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_8.Text, out digit8))
            {
                if (kasaBox2_8.Text.IndexOf(',') != -1 && kasaBox2_8.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_8.Focus();
                }
                else
                    kasaBox2_8.Text = String.Format("{0:N2}", digit8);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_8.Focus();
            }
        }

        private void kasaBox2_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa9
        private void kasaBox2_9_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_9.Text, out digit9))
            {
                if (kasaBox2_9.Text.IndexOf(',') != -1 && kasaBox2_9.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_9.Focus();
                }
                else
                    kasaBox2_9.Text = String.Format("{0:N2}", digit9);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_9.Focus();
            }
        }

        private void kasaBox2_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //kasa
        private void kasaBox2_0_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(kasaBox2_0.Text, out digit0))
            {
                if (kasaBox2_0.Text.IndexOf(',') != -1 && kasaBox2_0.Text.Split(',')[1].Length > 2)
                {
                    MessageBox.Show("Dopuszczalne są 2 miejsca po przecinku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kasaBox2_0.Focus();
                }
                else
                    kasaBox2_0.Text = String.Format("{0:N2}", digit0);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kasaBox2_0.Focus();
            }
        }

        private void kasaBox2_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar == ',')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        #endregion

        #region LOAD - READY

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel2.Text = DateTime.Now.ToLongDateString();
            timeLabel2.Text = DateTime.Now.ToLongTimeString();

            profilLabel2.Text = profilName;
            panel2a.Enabled = false;
            panel2b.Enabled = false;
            zmienButton2.Visible = false;

            DatabaseConnect.Open();

            try
            {
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = DatabaseConnect;

                string LoadQuery = "SELECT TOP 1 [listaAccest2_1], [listaAccest2_2], [listaAccest2_3], [listaAccest2_4], [listaAccest2_5], [listaAccest2_6], [listaAccest2_7], [listaAccest2_8], [listaAccest2_9], [listaAccest2_0], [kasaAcces2_1], [kasaAcces2_2], [kasaAcces2_3], [kasaAcces2_4], [kasaAcces2_5], [kasaAcces2_6], [kasaAcces2_7], [kasaAcces2_8], [kasaAcces2_9], [kasaAcces2_0], [sumaMiesiac], [wygranaMiesiaca] FROM nagroda WHERE [imieBeata] = '" + profilName + "' ORDER BY [data] DESC ";
                
                myCommand.CommandText = LoadQuery;

                OleDbDataReader readings = myCommand.ExecuteReader();

                if (readings.Read())
                {
                    listaBox2_1.Text = readings[0].ToString();
                    listaBox2_2.Text = readings[1].ToString();
                    listaBox2_3.Text = readings[2].ToString();
                    listaBox2_4.Text = readings[3].ToString();
                    listaBox2_5.Text = readings[4].ToString();
                    listaBox2_6.Text = readings[5].ToString();
                    listaBox2_7.Text = readings[6].ToString();
                    listaBox2_8.Text = readings[7].ToString();
                    listaBox2_9.Text = readings[8].ToString();
                    listaBox2_0.Text = readings[9].ToString();

                    float1 = (String.Format("{0:N2}", readings[10]));
                    float2 = (String.Format("{0:N2}", readings[11]));
                    float3 = (String.Format("{0:N2}", readings[12]));
                    float4 = (String.Format("{0:N2}", readings[13]));
                    float5 = (String.Format("{0:N2}", readings[14]));
                    float6 = (String.Format("{0:N2}", readings[15]));
                    float7 = (String.Format("{0:N2}", readings[16]));
                    float8 = (String.Format("{0:N2}", readings[17]));
                    float9 = (String.Format("{0:N2}", readings[18]));
                    float0 = (String.Format("{0:N2}", readings[19]));

                    miesiacBox2.Text = (String.Format("{0:N2}", readings[20]));
                    monthlyAward = (String.Format("{0:N2}", readings[21]));
                    nagrodaBox2.Text = monthlyAward;

                    kasaBox2_1.Text = "0,00";
                    kasaBox2_2.Text = "0,00";
                    kasaBox2_3.Text = "0,00";
                    kasaBox2_4.Text = "0,00";
                    kasaBox2_5.Text = "0,00";
                    kasaBox2_6.Text = "0,00";
                    kasaBox2_7.Text = "0,00";
                    kasaBox2_8.Text = "0,00";
                    kasaBox2_9.Text = "0,00";
                    kasaBox2_0.Text = "0,00";
                }

                else { }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd wczytywania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                DatabaseConnect.Close();
            }
        }
        #endregion

        #region SAVE -READY

        private void zapiszButton2_Click(object sender, EventArgs e)
        {

            //loading data from [data] to variables

            DatabaseConnect.Open();

            datecheck1 = DateTime.Now.ToShortDateString();

            try
            {
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = DatabaseConnect;

                string LoadQuery = "SELECT [data] FROM nagroda WHERE [data] = #" + datecheck1 + "# AND [imieBeata] = '" + profilName + "'  ";

                myCommand.CommandText = LoadQuery;

                OleDbDataReader readings = myCommand.ExecuteReader();

                if (readings.Read())
                {

                    datecheck2 = String.Format("{0:yyyy-MM-dd}", readings[0]);
                }

                else { }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd wczytywania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //checking for readings if exists

            if (datecheck1 == datecheck2)
            {
                panel2a.Enabled = false;
                panel2b.Enabled = false;
                panel2c.Enabled = false;
                edycjaProfilu2.Enabled = false;

                //loading today's archive records

                datecheck1 = DateTime.Now.ToShortDateString();

                try
                {

                    OleDbCommand myCommand = new OleDbCommand();
                    myCommand.Connection = DatabaseConnect;
                    
                    string loadCommand = "SELECT [listaAccest2_1], [listaAccest2_2], [listaAccest2_3], [listaAccest2_4], [listaAccest2_5], [listaAccest2_6], [listaAccest2_7], [listaAccest2_8], [listaAccest2_9], [listaAccest2_0], [checkAcces2_1], [checkAcces2_2], [checkAcces2_3], [checkAcces2_4], [checkAcces2_5], [checkAcces2_6], [checkAcces2_7], [checkAcces2_8], [checkAcces2_9], [checkAcces2_0] FROM nagroda WHERE [data] = #" + datecheck1 + "# AND [imieBeata] = '" + profilName + "' ";

                    myCommand.CommandText = loadCommand;

                    OleDbDataReader readings = myCommand.ExecuteReader();

                    if (readings.Read())

                    {
                       // fieldNAZWA
                        listaBox2_1.Text = readings[0].ToString();
                        listaBox2_2.Text = readings[1].ToString();
                        listaBox2_3.Text = readings[2].ToString();
                        listaBox2_4.Text = readings[3].ToString();
                        listaBox2_5.Text = readings[4].ToString();
                        listaBox2_6.Text = readings[5].ToString();
                        listaBox2_7.Text = readings[6].ToString();
                        listaBox2_8.Text = readings[7].ToString();
                        listaBox2_9.Text = readings[8].ToString();
                        listaBox2_0.Text = readings[9].ToString();

                        //fieldCHECKBOX to variables
                        boolean1 = Convert.ToBoolean(readings[10]);
                        boolean2 = Convert.ToBoolean(readings[11]);
                        boolean3 = Convert.ToBoolean(readings[12]);
                        boolean4 = Convert.ToBoolean(readings[13]);
                        boolean5 = Convert.ToBoolean(readings[14]);
                        boolean6 = Convert.ToBoolean(readings[15]);
                        boolean7 = Convert.ToBoolean(readings[16]);
                        boolean8 = Convert.ToBoolean(readings[17]);
                        boolean9 = Convert.ToBoolean(readings[18]);
                        boolean0 = Convert.ToBoolean(readings[19]);
                        
                        //fieldCHECKBOX to textBoxes
                        checkBox2_1.Checked = boolean1;
                        checkBox2_2.Checked = boolean2;
                        checkBox2_3.Checked = boolean3;
                        checkBox2_4.Checked = boolean4;
                        checkBox2_5.Checked = boolean5;
                        checkBox2_6.Checked = boolean6;
                        checkBox2_7.Checked = boolean7;
                        checkBox2_8.Checked = boolean8;
                        checkBox2_9.Checked = boolean9;
                        checkBox2_0.Checked = boolean0;

                        // fieldKASA
                        if (boolean1 == true)
                            kasaBox2_1.Text = float1;
                        else
                            kasaBox2_1.Text = "0,00";

                        if (boolean2 == true)
                            kasaBox2_2.Text = float2;
                        else
                            kasaBox2_2.Text = "0,00";

                        if (boolean3 == true)
                            kasaBox2_3.Text = float3;
                        else
                            kasaBox2_3.Text = "0,00";

                        if (boolean4 == true)
                            kasaBox2_4.Text = float4;
                        else
                            kasaBox2_4.Text = "0,00";

                        if (boolean5 == true)
                            kasaBox2_5.Text = float5;
                        else
                            kasaBox2_5.Text = "0,00";

                        if (boolean6 == true)
                            kasaBox2_6.Text = float6;
                        else
                            kasaBox2_6.Text = "0,00";

                        if (boolean7 == true)
                            kasaBox2_7.Text = float7;
                        else
                            kasaBox2_7.Text = "0,00";

                        if (boolean8 == true)
                            kasaBox2_8.Text = float8;
                        else
                            kasaBox2_8.Text = "0,00";

                        if (boolean9 == true)
                            kasaBox2_9.Text = float9;
                        else
                            kasaBox2_9.Text = "0,00";

                        if (boolean0 == true)
                            kasaBox2_0.Text = float0;
                        else
                            kasaBox2_0.Text = "0,00";
                    }

                    else { }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd wczytywania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                MessageBox.Show("Wpis na dziś już istnieje", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // DataBase UPDATE - if readings doesnt exist (SAVE)

            else
            {
                datecheck1 = DateTime.Now.ToShortDateString();

                if (boolean1 != false || boolean2 != false || boolean3 != false || boolean4 != false || boolean5 != false || boolean6 != false || boolean7 != false || boolean8 != false || boolean9 != false || boolean0 != false)
                {
                    MonthlyReset();

                    MonthAdding();

                    try
                    {
                        OleDbCommand myCommand = new OleDbCommand();
                        myCommand.Connection = DatabaseConnect;
                        myCommand.CommandText = "INSERT INTO nagroda ( [data], [listaAccest2_1], [listaAccest2_2], [listaAccest2_3], [listaAccest2_4], [listaAccest2_5], [listaAccest2_6], [listaAccest2_7], [listaAccest2_8], [listaAccest2_9], [listaAccest2_0], [checkAcces2_1], [checkAcces2_2], [checkAcces2_3], [checkAcces2_4], [checkAcces2_5], [checkAcces2_6], [checkAcces2_7], [checkAcces2_8], [checkAcces2_9], [checkAcces2_0], [kasaAcces2_1], [kasaAcces2_2], [kasaAcces2_3], [kasaAcces2_4], [kasaAcces2_5], [kasaAcces2_6], [kasaAcces2_7], [kasaAcces2_8], [kasaAcces2_9], [kasaAcces2_0], [imieBeata], [sumaDzien], [sumaMiesiac], [wygranaMiesiaca]) VALUES ('" + datecheck1 + "' ,'" + listaBox2_1.Text + "', '" + listaBox2_2.Text + "', '" + listaBox2_3.Text + "', '" + listaBox2_4.Text + "', '" + listaBox2_5.Text + "', '" + listaBox2_6.Text + "', '" + listaBox2_7.Text + "', '" + listaBox2_8.Text + "', '" + listaBox2_9.Text + "', '" + listaBox2_0.Text + "', " + checkBox2_1.Checked.ToString() + ", " + checkBox2_2.Checked.ToString() + ", " + checkBox2_3.Checked.ToString() + ", " + checkBox2_4.Checked.ToString() + ", " + checkBox2_5.Checked.ToString() + ", " + checkBox2_6.Checked.ToString() + ", " + checkBox2_7.Checked.ToString() + ", " + checkBox2_8.Checked.ToString() + ", " + checkBox2_9.Checked.ToString() + ", " + checkBox2_0.Checked.ToString() + ", '" + float1 + "', '" + float2 + "', '" + float3 + "', '" + float4 + "', '" + float5 + "', '" + float6 + "', '" + float7 + "', '" + float8 + "', '" + float9 + "', '" + float0 + "', '" + profilLabel2.Text + "', '" + dzienBox2.Text + "', '" + miesiacBox2.Text + "', '" + monthlyAward + "')";

                        myCommand.ExecuteNonQuery();

                        MessageBox.Show("Zapisano do Archiwum", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        panel2a.Enabled = false;
                        panel2b.Enabled = false;
                        panel2c.Enabled = false;
                        edycjaProfilu2.Enabled = false;
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Nie zaznaczono żadnych czynności z Listy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

            DatabaseConnect.Close();
        }
        #endregion

        #region LOAD ARCHIVE - IN PROGRESS

        private void wczytajButton2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            DatabaseConnect.Open();

            try
            {

                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = DatabaseConnect;

                string loadCommand = "SELECT [listaAccest2_1], [listaAccest2_2], [listaAccest2_3], [listaAccest2_4], [listaAccest2_5], [listaAccest2_6], [listaAccest2_7], [listaAccest2_8], [listaAccest2_9], [listaAccest2_0], [kasaAcces2_1], [kasaAcces2_2], [kasaAcces2_3], [kasaAcces2_4], [kasaAcces2_5], [kasaAcces2_6], [kasaAcces2_7], [kasaAcces2_8], [kasaAcces2_9], [kasaAcces2_0], [checkAcces2_1], [checkAcces2_2], [checkAcces2_3], [checkAcces2_4], [checkAcces2_5], [checkAcces2_6], [checkAcces2_7], [checkAcces2_8], [checkAcces2_9], [checkAcces2_0], [data], [sumaDzien] FROM nagroda WHERE [data] = #" + dateTimeArchiwum2.Value.ToShortDateString() + "# AND [imieBeata] = '" + profilName + "' ";

                myCommand.CommandText = loadCommand;

                OleDbDataReader readings = myCommand.ExecuteReader();

                if (readings.Read())

                {
                    // poleNAZWA
                    f3.textArchiwum1 = readings[0].ToString();
                    f3.textArchiwum2 = readings[1].ToString();
                    f3.textArchiwum3 = readings[2].ToString();
                    f3.textArchiwum4 = readings[3].ToString();
                    f3.textArchiwum5 = readings[4].ToString();
                    f3.textArchiwum6 = readings[5].ToString();
                    f3.textArchiwum7 = readings[6].ToString();
                    f3.textArchiwum8 = readings[7].ToString();
                    f3.textArchiwum9 = readings[8].ToString();
                    f3.textArchiwum0 = readings[9].ToString();

                    // poleKASA
                    f3.textArchiwum1a = (String.Format("{0:N2}", readings[10]));
                    f3.textArchiwum2a = (String.Format("{0:N2}", readings[11]));
                    f3.textArchiwum3a = (String.Format("{0:N2}", readings[12]));
                    f3.textArchiwum4a = (String.Format("{0:N2}", readings[13]));
                    f3.textArchiwum5a = (String.Format("{0:N2}", readings[14]));
                    f3.textArchiwum6a = (String.Format("{0:N2}", readings[15]));
                    f3.textArchiwum7a = (String.Format("{0:N2}", readings[16]));
                    f3.textArchiwum8a = (String.Format("{0:N2}", readings[17]));
                    f3.textArchiwum9a = (String.Format("{0:N2}", readings[18]));
                    f3.textArchiwum0a = (String.Format("{0:N2}", readings[19]));

                    //polaCHECKBOX
                    f3.textArchiwum1b = Convert.ToBoolean(readings[20]);
                    f3.textArchiwum2b = Convert.ToBoolean(readings[21]);
                    f3.textArchiwum3b = Convert.ToBoolean(readings[22]);
                    f3.textArchiwum4b = Convert.ToBoolean(readings[23]);
                    f3.textArchiwum5b = Convert.ToBoolean(readings[24]);
                    f3.textArchiwum6b = Convert.ToBoolean(readings[25]);
                    f3.textArchiwum7b = Convert.ToBoolean(readings[26]);
                    f3.textArchiwum8b = Convert.ToBoolean(readings[27]);
                    f3.textArchiwum9b = Convert.ToBoolean(readings[28]);
                    f3.textArchiwum0b = Convert.ToBoolean(readings[29]);

                    f3.textArchiwum1c = String.Format("{0:dd/MM/yyyy}", readings[30]);
                    f3.textArchiwum1d = (String.Format("{0:N2}", readings[31]));
                }

                else { }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd wczytywania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DatabaseConnect.Close();
            f3.ShowDialog();
        }
        #endregion
        
        #region CLOSE

        private void zamknijButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ProfileEdit_CheckBox

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (edycjaProfilu2.Checked == true)
            {
                panel2a.Enabled = true;
                panel2b.Enabled = true;
                zmienButton2.Visible = true;

                checkBox2_1.Enabled = false;
                checkBox2_2.Enabled = false;
                checkBox2_3.Enabled = false;
                checkBox2_4.Enabled = false;
                checkBox2_5.Enabled = false;
                checkBox2_6.Enabled = false;
                checkBox2_7.Enabled = false;
                checkBox2_8.Enabled = false;
                checkBox2_9.Enabled = false;
                checkBox2_0.Enabled = false;

                zapiszButton2.Enabled = false;
                wczytajButton2.Enabled = false;
                dateTimeArchiwum2.Enabled = false;

                checkBox2_1.Checked = false;
                checkBox2_2.Checked = false;
                checkBox2_3.Checked = false;
                checkBox2_4.Checked = false;
                checkBox2_5.Checked = false;
                checkBox2_6.Checked = false;
                checkBox2_7.Checked = false;
                checkBox2_8.Checked = false;
                checkBox2_9.Checked = false;
                checkBox2_0.Checked = false;

            }
            else { }

            if(edycjaProfilu2.Checked == false)
            {
                panel2a.Enabled = false;
                panel2b.Enabled = false;
                zmienButton2.Visible = false;

                checkBox2_1.Enabled = true;
                checkBox2_2.Enabled = true;
                checkBox2_3.Enabled = true;
                checkBox2_4.Enabled = true;
                checkBox2_5.Enabled = true;
                checkBox2_6.Enabled = true;
                checkBox2_7.Enabled = true;
                checkBox2_8.Enabled = true;
                checkBox2_9.Enabled = true;
                checkBox2_0.Enabled = true;

                zapiszButton2.Enabled = true;
                wczytajButton2.Enabled = true;
                dateTimeArchiwum2.Enabled = true;

            }
            else { }
        }
        #endregion

        #region EDIT (zmien_button)

        private void zmienButton2_Click(object sender, EventArgs e)
        {
            //TERAZ DANE
            panel2a.Enabled = false;
            panel2b.Enabled = false;
            zmienButton2.Visible = false;
            edycjaProfilu2.Checked = false;

            if (kasaBox2_1.Text != "0,00")
            {
                float1 = (String.Format("{0:N2}", kasaBox2_1.Text));
                kasaBox2_1.Text = "0,00";
            }
            if (kasaBox2_2.Text != "0,00")
            {
                float2 = (String.Format("{0:N2}", kasaBox2_2.Text));
                kasaBox2_2.Text = "0,00";
            }
            if (kasaBox2_3.Text != "0,00")
            {
                float3 = (String.Format("{0:N2}", kasaBox2_3.Text));
                kasaBox2_3.Text = "0,00";
            }
            if (kasaBox2_4.Text != "0,00")
            {
                float4 = (String.Format("{0:N2}", kasaBox2_4.Text));
                kasaBox2_4.Text = "0,00";
            }
            if (kasaBox2_5.Text != "0,00")
            {
                float5 = (String.Format("{0:N2}", kasaBox2_5.Text));
                kasaBox2_5.Text = "0,00";
            }
            if (kasaBox2_6.Text != "0,00")
            {
                float6 = (String.Format("{0:N2}", kasaBox2_6.Text));
                kasaBox2_6.Text = "0,00";
            }
            if (kasaBox2_7.Text != "0,00")
            {
                float7 = (String.Format("{0:N2}", kasaBox2_7.Text));
                kasaBox2_7.Text = "0,00";
            }
            if (kasaBox2_8.Text != "0,00")
            {
                float8 = (String.Format("{0:N2}", kasaBox2_8.Text));
                kasaBox2_8.Text = "0,00";
            }
            if (kasaBox2_9.Text != "0,00")
            {
                float9 = (String.Format("{0:N2}", kasaBox2_9.Text));
                kasaBox2_9.Text = "0,00";
            }
            if (kasaBox2_0.Text != "0,00")
            {
                float0 = (String.Format("{0:N2}", kasaBox2_0.Text));
                kasaBox2_0.Text = "0,00";
            }

            checkBox2_1.Enabled = true;
            checkBox2_2.Enabled = true;
            checkBox2_3.Enabled = true;
            checkBox2_4.Enabled = true;
            checkBox2_5.Enabled = true;
            checkBox2_6.Enabled = true;
            checkBox2_7.Enabled = true;
            checkBox2_8.Enabled = true;
            checkBox2_9.Enabled = true;
            checkBox2_0.Enabled = true;

            MessageBox.Show("Wprowadzono zmiany" + "\n" + "____________________________________________\nZmiany zostaną zachowanie na stałe" + " \n" + "po zapisaniu osiągnieć z aktualnego dnia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region RealTime_CheckBoxes

        private void checkBox2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_1.Checked == true)
            {
                boolean1 = true;
                kasaBox2_1.Text = float1;
                digit1 = Convert.ToDouble(float1);
                SumDay();
                
            }
            else { }

            if (checkBox2_1.Checked == false)
            {
                boolean1 = false;
                kasaBox2_1.Text = "0,00";
                digit1 = 0;
                SumDay();
                
            }
            else { }

        }

        private void checkBox2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_2.Checked == true)
            {
                boolean2 = true;
                kasaBox2_2.Text = float2;
                digit2 = Convert.ToDouble(float2);
                SumDay();
                
            }
            else { }

            if (checkBox2_2.Checked == false)
            {
                boolean2 = false;
                kasaBox2_2.Text = "0,00";
                digit2 = 0;
                SumDay();
                
            }
            else { }
            
        }

        private void checkBox2_3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_3.Checked == true)
            {
                boolean3 = true;
                kasaBox2_3.Text = float3;
                digit3 = Convert.ToDouble(float3);
                SumDay();
                
            }
            else { }

            if (checkBox2_3.Checked == false)
            {
                boolean3 = false;
                kasaBox2_3.Text = "0,00";
                digit3 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_4.Checked == true)
            {
                boolean4 = true;
                kasaBox2_4.Text = float4;
                digit4 = Convert.ToDouble(float4);
                SumDay();
                
            }
            else { }

            if (checkBox2_4.Checked == false)
            {
                boolean4 = false;
                kasaBox2_4.Text = "0,00";
                digit4 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_5.Checked == true)
            {
                boolean5 = true;
                kasaBox2_5.Text = float5;
                digit5 = Convert.ToDouble(float5);
                SumDay();
                
            }
            else { }

            if (checkBox2_5.Checked == false)
            {
                boolean5 = false;
                kasaBox2_5.Text = "0,00";
                digit5 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_6.Checked == true)
            {
                boolean6 = true;
                kasaBox2_6.Text = float6;
                digit6 = Convert.ToDouble(float6);
                SumDay();
                
            }
            else { }

            if (checkBox2_6.Checked == false)
            {
                boolean6 = false;
                kasaBox2_6.Text = "0,00";
                digit6 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_7.Checked == true)
            {
                boolean7 = true;
                kasaBox2_7.Text = float7;
                digit7 = Convert.ToDouble(float7);
                SumDay();
                
            }
            else { }

            if (checkBox2_7.Checked == false)
            {
                boolean7 = false;
                kasaBox2_7.Text = "0,00";
                digit7 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_8.Checked == true)
            {
                boolean8 = true;
                kasaBox2_8.Text = float8;
                digit8 = Convert.ToDouble(float8);
                SumDay();
                
            }
            else { }

            if (checkBox2_8.Checked == false)
            {
                boolean8 = false;
                kasaBox2_8.Text = "0,00";
                digit8 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_9.Checked == true)
            {
                boolean9 = true;
                kasaBox2_9.Text = float9;
                digit9 = Convert.ToDouble(float9);
                SumDay();
                
            }
            else { }

            if (checkBox2_9.Checked == false)
            {
                boolean9 = false;
                kasaBox2_9.Text = "0,00";
                digit9 = 0;
                SumDay();
                
            }
            else { }
        }

        private void checkBox2_0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_0.Checked == true)
            {
                boolean0 = true;
                kasaBox2_0.Text = float0;
                digit0 = Convert.ToDouble(float0);
                SumDay();
                
            }
            else { }

            if (checkBox2_0.Checked == false)
            {
                boolean0 = false;
                kasaBox2_0.Text = "0,00";
                digit0 = 0;
                SumDay();
                
            }
            else { }
        }

        #endregion

        #region date&time
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        #endregion
        
       
        #region METHODS

        private void SumDay()
        {
            dailyValue = digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7 + digit8 + digit9 + digit0;
            dzienBox2.Text = (String.Format("{0:N2}", dailyValue));
        }

        private void MonthAdding()
        {
            monthlyValue = Convert.ToDouble(miesiacBox2.Text);
            monthlyValue = monthlyValue + (digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7 + digit8 + digit9 + digit0);
            miesiacBox2.Text = (String.Format("{0:N2}", monthlyValue));
        }
        
        private void MonthlyReset() 
        {
            var day = DateTime.Today.Day;

            if (day == 1)
            {
                //passing
                monthlyAward = miesiacBox2.Text;
                nagrodaBox2.Text = monthlyAward;
                
                //reset
                miesiacBox2.Text = "0,00";
            }
            else { }
        }
        #endregion
    }
}

    