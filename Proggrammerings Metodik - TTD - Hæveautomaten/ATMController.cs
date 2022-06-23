using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    /// <summary>
    /// Main controller for the ATM functions
    /// </summary>
    public class ATMController
    {
        private Validator validator;
        private CardReader cardReader;

        public ATMController()
        {
            validator = new Validator();
            cardReader = new CardReader();
        }



        public bool ValidatePin(string pin)
        {
            return validator.ValidatePin(pin);
        }

        public bool ValidateCard(Card card)
        {
            string cardNumber = cardReader.ReadCard(card);
            return validator.ValidateCard(cardNumber);
        }
    }
}
