using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_projesi
{
    class Ödeme
    {
         public float vergiCarpani = 0.08f;
         public float Vergilendir(float SubTotal)
        {
            float TaxedTotal = SubTotal * vergiCarpani;
            if (TaxedTotal >= 100)
                TaxedTotal += 10;

            return TaxedTotal;
        }
    }



    class CreditCard : Ödeme
    {

        
        
        
        
        

    }

    class Check : Ödeme 
    {


    }
}
