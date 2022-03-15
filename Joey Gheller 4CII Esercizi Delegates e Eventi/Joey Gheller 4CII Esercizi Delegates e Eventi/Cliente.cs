using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joey_Gheller_4CII_Esercizi_Delegates_e_Eventi
{
    class Cliente
    {
        public event EventHandler ErrorSaldo;
        

        public string Nome { get; }
        public string Cognome { get; }
        public string Indirizzo { get; }
       
        private int saldo;

        public Cliente(string nome, string cognome, string indirizzo, int saldo)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Saldo = saldo;
        }

        public int Saldo
        {
            get => saldo;
            set
            {

                if (Int32.TryParse(Convert.ToString(value), out int n))
                {
                    saldo = value;
                }
                else
                {
                    ErrorSaldo?.Invoke(null, null);
                }
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome} Cognome: {Cognome} Indirizzo: {Indirizzo} Saldo: {Saldo}";
        }
    }
}
