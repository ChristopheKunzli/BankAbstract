namespace BankTests
{
    public class SavingsAccountTest
    {
        [Test]
        public void Interest_balanceIsPositive()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", 100, DateTime.Now);

            float expected = (float)30.0;
            float actual = acc.Interest();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Interest_balanceIsZero()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", 0, DateTime.Now);

            float expected = (float)0.0;
            float actual = acc.Interest();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Interest_balanceIsNegative()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", -100, DateTime.Now);

            float expected = (float)-30.0;
            float actual = acc.Interest();

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Interest_balanceIsPositive_Integrate()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", 100, DateTime.Now);

            float expected = acc.Balance + (float)30.0;
            acc.Interest(true);

            float actual = acc.Balance;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Interest_balanceIsZero_Integrate()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", 0, DateTime.Now);

            float expected = acc.Balance + (float)0.0;
            acc.Interest(true);

            float actual = acc.Balance;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Interest_balanceIsNegative_Integrate()
        {
            SavingAccount acc = new SavingAccount(30, "1423423", -100, DateTime.Now);

            float expected = acc.Balance + (float)-30.0;
            acc.Interest(true);

            float actual = acc.Balance;

            Assert.AreEqual(expected, actual);
        }
    }
}
