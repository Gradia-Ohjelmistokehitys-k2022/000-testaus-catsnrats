using Bank.Controller;

// The 'using' statement for Test Tools is in GlobalUsings.cs
// using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    // ### Luokka sisältää testimetodeja Account- ja Customer-luokille ### //
    [TestClass]
    public class BankTests
    {
        // ### Account-luokan testejä ### //

        // [ExpectedException(typeof(ArgumentException)) <== muistiin, mikäli 'TestMethod' ei jstn syystä toimi
        [TestMethod]       
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 100.00;
            double debitAmount = 120.00;
            string customerName = "Alice Quasicrystal";
            Customer customer = new Customer(customerName);
            // uusi tili asiakkaalle
            Account account = new Account(customerName, beginningBalance);
            customer.AddAccount(account);
            // Act and assert            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 150.00;
            double debitAmount = -100.00;
            string customerName = "Mr. Choco Mochaccino";
            Customer customer = new Customer(customerName);
            Account account = new Account(customerName, beginningBalance);
            customer.AddAccount(account);
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
            string customerName = "Albert Atom";
            Customer customer = new Customer(customerName);
            Account account = new Account(customerName, beginningBalance);
            customer.AddAccount(account);
            // Act
            account.Debit(debitAmount); // kutsuu account instanssin Debit-metodia
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Credit_WithValidAmount_ShouldIncreaseBalance() // "good weather" testi Credit metodille
        {
            // arrange
            double beginningBalance = 50.0;
            double creditAmount = 30.0;
            string customerName = "Tenet Tetragon";
            double expectedBalance = beginningBalance + creditAmount;
            Customer customer = new Customer(customerName);
            Account account = new Account(customerName, beginningBalance);
            customer.AddAccount(account);
            // act
            account.Credit(creditAmount);
            // assert
            Assert.AreEqual(expectedBalance, account.Balance, 0.001, "Balance should be increased by the creditet amount");
        }
        [TestMethod]
        public void Credit_WithNegAmount_ShouldThrowArgumentOutOfRange() // bad weather -testi Credit metodille
        {
            // arrange
            double beginningBalance = 50.0;
            double creditAmount = -10.0;
            string customerName = "El Señor Gato";
            Customer customer = new Customer(customerName);
            Account account = new Account(customerName, beginningBalance); 
            customer.AddAccount(account);
            // act & assert            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Credit(creditAmount));            
        }

        // ### Customer-luokan testejä ### //
        [TestMethod]
        public void CreateCustomer_ValidName_CustomerCreated() // Customer-luokan testi. Onko nimi "validi", ei null / tyhjä
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
        [TestMethod]
        public void CreateCustomer_InvalidName_ThrowsArgumentException() // TARKISTA TÄMÄ SEURAAVALLA KERRALLA
        {
            // arrange
            string invalidName = null;
            // act & assert
            Assert.ThrowsException<ArgumentException>(() => new Customer(invalidName));
        }
        [TestMethod]
        public void AddAccount_NullAccount_ThrowsArgumentNullException()
        {
            // arrange
            Customer customer = new Customer("Mrs. Rabbit");
            // act & assert
            Assert.ThrowsException<ArgumentNullException>(() => customer.AddAccount(null));            
        }
    }
}