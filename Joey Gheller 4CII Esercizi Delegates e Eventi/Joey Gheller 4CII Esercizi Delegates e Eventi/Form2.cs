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
    public partial class Form2 : Form
    {
        Cliente Client;
        public Form2()
        {
            InitializeComponent();
        }

        private void Client_ErrorSaldo(object sender, EventArgs e)
        {
            MessageBox.Show("erore");
        }

        private void btnGETCLIENT_Click(object sender, EventArgs e)
        { 

            Client = new Cliente(txbnoem.Text, txbcognome.Text, txbindirizzo.Text, Convert.ToInt32(txbSaldo.Text));
            Client.ErrorSaldo += Client_ErrorSaldo;
            MessageBox.Show(Client.ToString());

        }

        private void btnVers_Click(object sender, EventArgs e)
        {
            int newSaldo = Convert.ToInt32(txbSaldo.Text) + Convert.ToInt32(txbImporto.Text);
            txbSaldo.Text = Convert.ToString(newSaldo);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txbSaldo.Text) > Convert.ToInt32(txbImporto.Text))
            {
                int newSaldo = Convert.ToInt32(txbSaldo.Text) - Convert.ToInt32(txbImporto.Text);
                txbSaldo.Text = Convert.ToString(newSaldo);
            }
            else
            {
                Client.ErrorSaldo += Client_ErrorSaldo;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbnoem.Text = "";
            txbcognome.Text = "";
            txbindirizzo.Text = "";
            txbSaldo.Text = "";
            txbImporto.Text = "0";
        }
    }
}
