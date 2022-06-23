using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    /// <summary>
    /// Responsible for validating cards and PIN codes
    /// </summary>
    internal class Validator
    {

        public Validator()
        {

        }

        /// <summary>
        /// Validates PIN code.
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public bool ValidatePin(string pin)
        {
            if (pin == String.Empty)
            {
                throw new ArgumentNullException("PIN was null");
            }

            if (pin.Length != 4)
            {
                throw new ArgumentException("PIN was not correct length");
            }

            if (!IsDigitsOnly(pin))
            {
                throw new ArgumentException("PIN contained non-digit characters");
            }

            return true;

        }

        /// <summary>
        /// Validates the cardnumber.
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool ValidateCard(string cardNumber)
        {
            if (!IsDigitsOnly(cardNumber))
            {
                throw new ArgumentException("Cardnumber contained non-digit characters");
            }

            return true;
        }

        /// <summary>
        /// Checks if a string only contains digit chars
        /// </summary>
        /// <param name="str">String to test</param>
        /// <returns>True if only digits</returns>
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
