using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class alimentari : prodotto
    {
        public string[] _ingredienti = new string[10];
        public DateTime _scadenza;
        public alimentari(string[] ingredienti, DateTime datascadenza, string id, string nome, string prod, float prezzo) : base(id, nome, prod, prezzo)
        {
            _ingredienti = ingredienti;
            _scadenza = datascadenza;
        }
        public alimentari()
        {

        }
        public string[] Ingredienti
        {
            get { return _ingredienti; }
            private set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] != null)
                        _ingredienti[i] = value[i];
                    else
                        throw new Exception("Ingredienti non validi");
                }
            }
        }
        public DateTime Scadenza
        {
            private set { _scadenza = value; }
            get { return _scadenza; }
        }
        public alimentari[] ingredienti { get ; private set; }
        public string Sconto(DateTime scadenza, alimentari[] a )
        {
            var oggi = DateTime.Today;
            var giornirimanenti = oggi - Scadenza;
            if (giornirimanenti.Days < 7)
            {
                return  $"{this.Prezzo * 0.50}";
            }
            else
            {
                return $"{this.Prezzo}";
            }
        }
    }
    
}
