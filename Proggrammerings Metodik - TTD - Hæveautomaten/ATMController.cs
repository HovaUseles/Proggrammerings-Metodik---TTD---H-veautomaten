using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    public class ATMController
    {
        private Validator validator;

        public ATMController()
        {
            validator = new Validator();
        }

        public bool ValidatePin(string pin)
        {
            return validator.ValidatePin(pin);
        }

        public bool ValidateCard(string cardNumber)
        {
            return validator.ValidateCard(cardNumber);
        }
    }
}
