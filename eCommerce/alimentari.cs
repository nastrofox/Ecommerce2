using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class alimentari : prodotto
    {
        public List<string> Ingredienti { get; private set; }
        public DateTime Scadenza { get; private set; }

        public alimentari(List<string> ingredienti, DateTime dataScadenza, string id, string nome, string produttore, float prezzo) : base(id, nome, produttore, prezzo)
        {
            Ingredienti = ingredienti;
            Scadenza = dataScadenza;
        }

        public alimentari() : base()
        {
            Ingredienti = new List<string>();
        }

        public string Sconto(DateTime scadenza)
        {
            var oggi = DateTime.Today;
            var giorniRimanenti = scadenza - oggi;

            if (giorniRimanenti.Days < 7)
            {
                return $"{Prezzo * 0.50}";
            }
            else
            {
                return $"{Prezzo}";
            }
        }
    }
    
}
