using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Linq
{
    public partial class Form1 : Form
    {
        List<string> Insegnanti;
        public Form1()
        {
            InitializeComponent();

            Insegnanti = new List<string>();
            Insegnanti.Add("Antonella Turso");
            Insegnanti.Add("Alberto Costa");
            Insegnanti.Add("Paolo Brunelli");
            Insegnanti.Add("Paolo De Rigo");
            Insegnanti.Add("Donatella Bertoletti");
            Insegnanti.Add("Salvatore Spinella");
            Insegnanti.Add("Fabrizio Lovison");
            Insegnanti.Add("Calamaro Volante");
        }

        private void Get1_Click(object sender, EventArgs e)
        {
            var nomiA = from n in Insegnanti
                                        where n.StartsWith("A")
                                        orderby n ascending 
                                        select n;

            IEnumerable nomiC = Insegnanti.Where(x => x.StartsWith("C")); 

            foreach (var name in nomiA)
            {
                txb2.AppendText(name + "\n");
            }
            foreach (var name in nomiC)
            {
                txb2.AppendText(name + "\n");
            }
        }

        private void Get2_Click(object sender, EventArgs e)
        {
            IEnumerable nomi = Insegnanti.Where(x => x.Length < 16).OrderByDescending(x => x.Length);
           
            foreach (var name in nomi)
            {
                txb3.AppendText(name + "\n");
            }
        }

        private void Get3_Click(object sender, EventArgs e)
        {
            IEnumerable nomi = Insegnanti.Where(x => x.Length < 14).OrderByDescending(x => x.Length);
           
            foreach (var name in nomi)
            {
                txb4.AppendText(name + "\n");
            }
        }
    }
}
