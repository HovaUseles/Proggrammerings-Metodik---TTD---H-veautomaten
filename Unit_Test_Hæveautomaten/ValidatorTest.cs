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
        public void ValidatePin_ValidData_ShouldValidate(string pin)
        {
            // Arrange


            // Act
            ATMController atm = new ATMController();
            bool actual = atm.ValidatePin(pin);

            // Assert
            Assert.True(actual);
        }


        [Theory]
        [InlineData("123")]
        [InlineData("123456")]
        public void ValidatePin_InvalidPin_ShouldFail(string pin) { 

            // Arrange
            ATMController atm = new ATMController();
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => atm.ValidatePin(pin));
        }

        [Theory]
        [InlineData("")]
        public void ValidatePin_EmptyPin_ShouldFail(string pin)
        {

            // Arrange
            ATMController atm = new ATMController();
            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => atm.ValidatePin(pin));
        }



        [Theory]
        [InlineData("1234567812345678")]
        public void ValidateCard_ValidData_ShouldWork(string cardNumber)
        {
            // Arrange
            ATMController atm = new ATMController();
            // Act

            // Assert
            Assert.True(atm.ValidateCard(cardNumber));
            //Assert.Throws<NotImplementedException>(() => atm.ValidateCard(cardNumber));
        }

        [Theory]
        [InlineData("123554abc12354")]
        public void ValidateCard_InvalidData_ShouldFail(string cardNumber)
        {
            // Arrange
            ATMController atm = new ATMController();
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => atm.ValidateCard(cardNumber));
        }

    }
}
