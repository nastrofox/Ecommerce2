using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class carrello
    {
        private string _id;
        private List<prodotto> Prodotti;
        private int a = 0, pos = 0, duplicati = 0;

        public carrello(string iden)
        {
            _id = iden;
            Prodotti = new List<prodotto>();
        }
        public int NProdotti
        {
            get { return a; }
        }
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public void Aggiungi(prodotto p)
        {
            if (a < 100 && p != null)
            {
                Prodotti.Add(p);
                a++;
            }
        }
        private int Esiste(prodotto p)
        {
            return Prodotti.IndexOf(p);
        }
        public void Rimuovi(prodotto p)
        {
            pos = Esiste(p);
            if (pos != -1)
            {
                Prodotti.RemoveAt(pos);
                a--;
            }
        }
        public void Svuota()
        {
            Prodotti.Clear();
            a = 0;
        }
        public List<prodotto> GetProdotti()
        {
            return Prodotti;
        }
        public int getDuplicati()
        {
            return duplicati;
        }
        
    }
}
