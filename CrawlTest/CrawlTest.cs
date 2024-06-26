using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CrawlTest
{
    [TestClass]
    public class CrawlTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange  
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Bank account = new Bank("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange  
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            Bank account = new Bank("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert is handled by ExpectedException  
        }
    }
}
