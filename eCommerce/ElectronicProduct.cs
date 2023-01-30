using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class ElectronicProduct : prodotto
    {
        public string _elettronica;
        DateTime giorno = DateTime.Now;

        public ElectronicProduct(string elettronica)
        {
            this._elettronica = elettronica;
        }
        public ElectronicProduct() : this(null)
        {

        }
        public string Elettronica
        {
            set
            {
                _elettronica = value;
            }
            get
            {
                return _elettronica;
            }
        }
        
        public string Discount(string id, DateTime giorno)
        {
            if (id == "elettronica")
            {
                if (giorno.DayOfWeek == DayOfWeek.Monday)
                {
                    this.Prezzo = this.Prezzo * 0.95;
                }
            }
            return id;
        }
        
    }
}
