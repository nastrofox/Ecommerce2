using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class ElectronicProduct  : prodotto
    {
        public string _id,_giorno;
        public float _sconto;
        

        public ElectronicProduct(string id,float sconto,string _giorno)
        {
            this._id = id;
            this._sconto = sconto;
        }
        public ElectronicProduct() : this(" ", 0 , " ")
        {

        }
        public string Id
        {
            set
            {
               _id = value;
            }
            get
            {
                return _id;
            }
        }
        public void Sconto(string id, float sconto,string giorno)
        {

        }

    }
}
