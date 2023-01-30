using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class alimentari : prodotto
    {
        public alimentari[] _ingredienti = new alimentari[10];
        public DateTime _scadenza;
        public alimentari(DateTime scadenza, alimentari[] ingredienti)
        {
            _ingredienti = ingredienti;
            _scadenza = scadenza;
        }
        public alimentari()
        {

        }
        public DateTime Scadenza
        {
            private set { _scadenza = value; }
            get { return _scadenza; }
        }
        public alimentari[] ingredienti { get ; private set; }
        public string controllo(DateTime scadenza, alimentari[] a )
        {
            TimeSpan dif = DateTime.Today - scadenza;
            if (dif.Days < 7)
            {
                return 
            }
            return "iudsagfid";
        }
    }
    
}
