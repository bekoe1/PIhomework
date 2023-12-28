using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
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
