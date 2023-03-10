namespace BankTests
{
    public class AccountTests
    {
        Account acc1;
        Account acc2;

        [SetUp]
        public void Setup()
        {
            acc1 = new CommonAccount(50, "4234234", 100, DateTime.Now);
            acc2 = new CommonAccount(40, "4234234", 30, DateTime.Now);
        }

        [Test]
        public void Deposit_basecase_Success()
        {
            acc1.Deposit(20);
            float actualBalance = acc1.Balance;
            float expectedBalance = 120;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]
        public void Deposit_amountLowerThanZero_Failure()
        {
            Assert.Throws<AmountLowerThanZeroException>(
                    delegate () { acc1.Deposit(-20); } ); 
        }

        [Test]
        public void Transfer_basecase_Success()
        {
            float transferAmount = 30;

            float expectedBalanceAcc1 = acc1.Balance - transferAmount;
            float expectedBalanceAcc2 = acc2.Balance + transferAmount;

            acc1.Transfer(transferAmount, acc2);

            float actualBalanceAcc1 = acc1.Balance;
            float actualBalanceAcc2 = acc2.Balance;

            Assert.AreEqual(expectedBalanceAcc1, actualBalanceAcc1);
            Assert.AreEqual(expectedBalanceAcc2, actualBalanceAcc2);
        }

        [Test]
        public void Transfer_amountLowerThanZero_Failure()
        {
            Assert.Throws<AmountLowerThanZeroException>(
                    delegate () { acc1.Transfer(-20, acc2); });
        }

        [Test]
        public void Transfer_AccountIsNull_Failure()
        {
            Assert.Throws<AccountNotExistingException>(
                    delegate () { acc1.Transfer(20, null); });
        }

        [Test]
        public void Withdraw_basecase_Success()
        {
            float withdrawAmount = 30;
            float expectedBalance = acc1.Balance - withdrawAmount;

            acc1.Withdraw(30);

            float actualBalance = acc1.Balance;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]
        public void Withdraw_AmountBelowZerol_Failure()
        {
            Assert.Throws<AmountLowerThanZeroException>(
                    delegate () { acc1.Withdraw(-20); });
        }

        [Test]
        public void Withdraw_AmountAboveLimitl_Failure()
        {
            Assert.Throws<OverdraftLimitHitException>(
                    delegate () { acc1.Withdraw(60); });
        }

        [Test]
        public void Withdraw_balanceTooLowl_Failure()
        {
            Account acc3 = new CommonAccount(100, "24424", 40, DateTime.Now);
            Assert.Throws<BalanceTooLowException>(
                    delegate () { acc3.Withdraw(60); });
        }
    }
}