namespace MojaPrvaWindowsAplikacija
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
            this.txtUnosbrojaA = new System.Windows.Forms.TextBox();
            this.txtUnosbrojaB = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.BrojA = new System.Windows.Forms.Label();
            this.BrojB = new System.Windows.Forms.Label();
            this.zbroj = new System.Windows.Forms.Label();
            this.Izracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnosbrojaA
            // 
            this.txtUnosbrojaA.Location = new System.Drawing.Point(81, 56);
            this.txtUnosbrojaA.Name = "txtUnosbrojaA";
            this.txtUnosbrojaA.Size = new System.Drawing.Size(100, 20);
            this.txtUnosbrojaA.TabIndex = 0;
            this.txtUnosbrojaA.TextChanged += new System.EventHandler(this.UnosbrojaA_TextChanged);
            // 
            // txtUnosbrojaB
            // 
            this.txtUnosbrojaB.Location = new System.Drawing.Point(446, 56);
            this.txtUnosbrojaB.Name = "txtUnosbrojaB";
            this.txtUnosbrojaB.Size = new System.Drawing.Size(100, 20);
            this.txtUnosbrojaB.TabIndex = 1;
            this.txtUnosbrojaB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(81, 259);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(100, 20);
            this.txtIspis.TabIndex = 2;
            this.txtIspis.TabStop = false;
            this.txtIspis.TextChanged += new System.EventHandler(this.txtIspis_TextChanged);
            // 
            // BrojA
            // 
            this.BrojA.AutoSize = true;
            this.BrojA.Location = new System.Drawing.Point(78, 40);
            this.BrojA.Name = "BrojA";
            this.BrojA.Size = new System.Drawing.Size(35, 13);
            this.BrojA.TabIndex = 3;
            this.BrojA.Text = "Broj A";
            // 
            // BrojB
            // 
            this.BrojB.AutoSize = true;
            this.BrojB.Location = new System.Drawing.Point(446, 40);
            this.BrojB.Name = "BrojB";
            this.BrojB.Size = new System.Drawing.Size(35, 13);
            this.BrojB.TabIndex = 4;
            this.BrojB.Text = "Broj B";
            // 
            // zbroj
            // 
            this.zbroj.AutoSize = true;
            this.zbroj.Location = new System.Drawing.Point(81, 243);
            this.zbroj.Name = "zbroj";
            this.zbroj.Size = new System.Drawing.Size(31, 13);
            this.zbroj.TabIndex = 5;
            this.zbroj.Text = "Zbroj";
            // 
            // Izracun
            // 
            this.Izracun.Location = new System.Drawing.Point(470, 255);
            this.Izracun.Name = "Izracun";
            this.Izracun.Size = new System.Drawing.Size(75, 23);
            this.Izracun.TabIndex = 6;
            this.Izracun.Text = "izračun";
            this.Izracun.UseVisualStyleBackColor = true;
            this.Izracun.Click += new System.EventHandler(this.Izracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Izracun);
            this.Controls.Add(this.zbroj);
            this.Controls.Add(this.BrojB);
            this.Controls.Add(this.BrojA);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtUnosbrojaB);
            this.Controls.Add(this.txtUnosbrojaA);
            this.Name = "Form1";
            this.Text = "Moja prva windows aplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosbrojaA;
        private System.Windows.Forms.TextBox txtUnosbrojaB;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label BrojA;
        private System.Windows.Forms.Label BrojB;
        private System.Windows.Forms.Label zbroj;
        private System.Windows.Forms.Button Izracun;
    }
}

