using NUnit.Framework;

 
namespace SimpleFermaThrm.Test
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void CalculateIntegral_ShouldReturnCorrectValue()
        {
            int second = Program.TestFunc(2);
            Assert.That(2 == second);
            Assert.That(4 != second);
            Assert.That(0 == 0);
        }
    }
}
