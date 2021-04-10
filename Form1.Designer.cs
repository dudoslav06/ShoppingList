
namespace Lista_zakupow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dodaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.wyczysc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(85, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 277);
            this.listBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(85, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(234, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(85, 359);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(234, 23);
            this.dodaj.TabIndex = 2;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(114, 388);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 23);
            this.usun.TabIndex = 3;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(215, 388);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(75, 23);
            this.wyczysc.TabIndex = 4;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(410, 480);
            this.Name = "Form1";
            this.Text = "Lista zakupów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button wyczysc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

