using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    internal class DebitCard : Card
    {
        public float MaxWithdraw { get; private set; }

        public DebitCard(string cardNumber, DateTime expiryDate, float maxWithdraw) : base(cardNumber, expiryDate)
        {
            MaxWithdraw = maxWithdraw;
        }
    }
}
