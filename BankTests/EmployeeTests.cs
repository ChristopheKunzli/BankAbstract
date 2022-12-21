namespace BankTests
{
    public class EmployeeTests
    {
        private BankEmployee emp1;
        private BankEmployee emp2;

        [SetUp]
        public void Setup()
        {
            emp1 = new HourEmployee("Paul", "Jean", new DateTime(1997,9,25), 0);
            emp2 = new CommercialEmployee("Paul", "Jeannette", new DateTime(1997,9,25), 0);
        }

        [Test]
        public void TestEmployee()
        {
            Assert.AreEqual(emp1.Name, "Paul");
        }
    }
}
