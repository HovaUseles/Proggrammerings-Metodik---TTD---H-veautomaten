using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proggrammerings_Metodik___TTD___Hæveautomaten
{
    /// <summary>
    /// Part of the ATM that reads the card inserted.
    /// </summary>
    internal class CardReader
    {
        /// <summary>
        /// Constructor for card reader
        /// </summary>
        public CardReader()
        {

        }

        /// <summary>
        /// Reads a card and returns the cardnumber if valid.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string ReadCard(Card card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("Card is null.");
            }

            if (card.CardNumber == null)
            {
                throw new ArgumentNullException("Cardnumber is null");
            }

            if (CardExpired(card))
            {
                throw new Exception("Card has expired.");
            }

            return card.CardNumber;
        }

        /// <summary>
        /// Checks if the card is 
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private bool CardExpired(Card card)
        {
            if (card.ExpiryDate > DateTime.UtcNow)
            {
                return false;
            }
            return true;
        }
    }
}
