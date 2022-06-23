using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    internal class Card
    {
        public string CardNumber { get; private set; }

        public DateTime ExpiryDate { get; private set; }

        public Card(string cardNumber, DateTime expiryDate)
        {
            CardNumber = cardNumber;    
            ExpiryDate = expiryDate;
        }
    }
}
