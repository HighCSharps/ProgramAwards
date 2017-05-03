namespace NagrodyZaMiesiac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.otworzButton1 = new System.Windows.Forms.Button();
            this.zamknijButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beata",
            "Piotr",
            "Izabela"});
            this.comboBox1.Location = new System.Drawing.Point(165, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(196, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz Profil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(65, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista czynności z Nagrodami";
            // 
            // otworzButton1
            // 
            this.otworzButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otworzButton1.Location = new System.Drawing.Point(116, 159);
            this.otworzButton1.Name = "otworzButton1";
            this.otworzButton1.Size = new System.Drawing.Size(104, 37);
            this.otworzButton1.TabIndex = 3;
            this.otworzButton1.Text = "Otwórz";
            this.otworzButton1.UseVisualStyleBackColor = true;
            this.otworzButton1.Click += new System.EventHandler(this.otworzButton1_Click);
            // 
            // zamknijButton1
            // 
            this.zamknijButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknijButton1.Location = new System.Drawing.Point(280, 159);
            this.zamknijButton1.Name = "zamknijButton1";
            this.zamknijButton1.Size = new System.Drawing.Size(104, 37);
            this.zamknijButton1.TabIndex = 5;
            this.zamknijButton1.Text = "Zamknij";
            this.zamknijButton1.UseVisualStyleBackColor = true;
            this.zamknijButton1.Click += new System.EventHandler(this.zamknijButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NagrodyZaMiesiac.Properties.Resources.GoldTrophy;
            this.pictureBox1.Location = new System.Drawing.Point(165, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.zamknijButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otworzButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno wyboru Profilu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button otworzButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zamknijButton1;
    }
}

