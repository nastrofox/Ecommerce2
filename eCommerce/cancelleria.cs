using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public abstract class cancelleria : prodotto
    {
        public cancelleria(string id, string nome, string prod, float prezzo) : base(id, nome, prod, prezzo)
        {
        }
        public double Sconto()
        {
            var oggi = DateTime.Today;

            if (oggi.Day % 2 == 0)
            {
                return this.Prezzo * 0.97;
            }
            else
            {
                return this.Prezzo;
            }
        }
    }
}



