using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joey_Gheller_4CII_Esercizi_Delegates_e_Eventi
{
    public partial class Form1 : Form
    {
        public delegate void Delegate(int n1, int n2);

        Delegate Del = (int n1, int n2) => { };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnicast_Click(object sender, EventArgs e)
        {
            Del += (int n1, int n2) => { 

                MessageBox.Show($"Risultato media: {(n1 + n2)/2}"); 
            };

        }

        private void btnMulticast_Click(object sender, EventArgs e)
        {
            Del += (int n1, int n2) => {

                MessageBox.Show($"Risultato media: {(n1 + n2) / 2}");
            };

            Del += (int n1, int n2) => {

                MessageBox.Show($"Risultato somma: {n1 + n2}");
            };

            Del += (int n1, int n2) => {

                MessageBox.Show($"Risultato max: {Math.Max(n1, n2)}");
            };

            Del += (int n1, int n2) =>
            {

                MessageBox.Show($"Risultato ipotenusa: {Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2))}");
            };
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Del.Invoke(Convert.ToInt32(txbN1.Text), Convert.ToInt32(txbN2.Text));
            Del = (int n1, int n2) => { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            Persona Person = new Persona(txb1.Text, Convert.ToInt32(txb2.Text));
            Person.ErrorEta += Person_ErrorEta;
            MessageBox.Show(Person.ToString());
        }

        private void Person_ErrorEta(object sender, EventArgs e)
        {
            MessageBox.Show("erore");
        }
    }
}
