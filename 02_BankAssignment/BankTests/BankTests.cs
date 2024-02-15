using Bank.Controller;

// The 'using' statement for Test Tools is in GlobalUsings.cs
// using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    // ### Luokka sis‰lt‰‰ testimetodeja Account- ja Customer-luokille ### //
    [TestClass]
    public class BankTests
    {
        // ### Account-luokan testej‰ ### //

        // [ExpectedException(typeof(ArgumentException)) <== muistiin, mik‰li 'TestMethod' ei jstn syyst‰ toimi
        [TestMethod] // test method attribuutti jokaisen testattavan metodin ylle        
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 111.00;
            double debitAmount = 120.00;
            Account account = new Account("Mr. Bryan Walton", beginningBalance);
            // Act and assert            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            Account account = new Account("Mr. Bryan Walton", beginningBalance);
            // Act and assert            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Account account = new Account("Mr. Bryan Walton", beginningBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        // ### Customer-luokan testej‰ ### //
        [TestMethod]
        public void CreateCustomer_ValidName_CustomerCreated() // Customer-luokan testi. Onko nimi "validi", ei null / tyhj‰
        {
            // arrange
            string customerName = "Pekka Pankkirosvo";
            // act
            Customer customer = new Customer(customerName);
            // assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerName, customer.CustomerName);
            Assert.AreEqual(0, customer.Accounts.Count);
        }
    }
}