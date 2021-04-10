using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_zakupow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                if(textBox1.Text.Length > 0)
                {
                    if(listBox1.Items.Contains(textBox1.Text))
                    {
                            DialogResult result = MessageBox.Show("Element już istnieje, czy chcesz go dodać ponownie?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(result == DialogResult.No)
                        {
                            return;
                        }

                    }
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    AktualizujProgress();
                }
                else
                {
                    MessageBox.Show("Wartość jest pusta!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lista jest już pełna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujProgress()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void usun_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i != -1)
            {
                listBox1.Items.RemoveAt(i);
                AktualizujProgress();
            }
            else
            {
                MessageBox.Show("Żaden element nie został zaznaczony!", "Błąd!", MessageBoxButtons.OK);
            }
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizujProgress();
        }
    }
}
