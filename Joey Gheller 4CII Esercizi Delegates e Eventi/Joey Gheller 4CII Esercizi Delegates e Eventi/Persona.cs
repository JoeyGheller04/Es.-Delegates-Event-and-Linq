using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joey_Gheller_4CII_Esercizi_Delegates_e_Eventi
{
    public class Persona
    {
        public event EventHandler ErrorEta;
        public Persona(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }

        public string Nome { get; }
        public int Eta {
            get => eta;
            set {

                if (Int32.TryParse(Convert.ToString(value), out int n))
                {
                    eta = value;
                }
                else
                {
                    ErrorEta?.Invoke(null, null);
                }
            }
        }
        private int eta;

        public override string ToString()
        {
            return $"Nome: {Nome} Eta: {Eta}";
        }

       
    }
}