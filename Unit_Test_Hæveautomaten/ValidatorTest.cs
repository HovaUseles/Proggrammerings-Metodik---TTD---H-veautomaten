using Proggrammerings_Metodik___TTD___Hæveautomaten;

namespace Unit_Test_Hæveautomaten
{
    /// <summary>
    /// Tests for the validater methods
    /// </summary>
    public class ValidatorTest
    {
        [Theory]
        [InlineData("1234")]
        public void ValidatePin_ValidData_isTrue(string pin)
        {
            // Arrange
            ATMController atm = new ATMController();

            // Act
            bool actual = atm.ValidatePin(pin);

            // Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("123")]
        [InlineData("123456")]
        [InlineData("13bc")]
        public void ValidatePin_InvalidData_Throws(string pin) { 

            // Arrange
            ATMController atm = new ATMController();

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => atm.ValidatePin(pin));
        }

        [Theory]
        [InlineData("")]
        public void ValidatePin_EmptyData_Throws(string pin)
        {

            // Arrange
            ATMController atm = new ATMController();

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => atm.ValidatePin(pin));
        }

        [Theory]
        [InlineData("1234567812345678")]
        public void ValidateCard_ValidData_isTrue(string cardNumber)
        {
            // Arrange
            ATMController atm = new ATMController();
            DateTime date = DateTime.Now;
            date.AddYears(3);
            DebitCard debitCard = new DebitCard(cardNumber, date, 5000);

            // Act

            // Assert
            Assert.True(atm.ValidateCard(debitCard));
            //Assert.Throws<NotImplementedException>(() => atm.ValidateCard(cardNumber));
        }

        [Theory]
        [InlineData("123554abc12354")]
        public void ValidateCard_InvalidData_Throws(string cardNumber)
        {
            // Arrange
            ATMController atm = new ATMController();
            DateTime date = DateTime.Now;
            date.AddYears(3);
            DebitCard debitCard = new DebitCard(cardNumber, date, 5000);

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => atm.ValidateCard(debitCard));
        }

    }
}
