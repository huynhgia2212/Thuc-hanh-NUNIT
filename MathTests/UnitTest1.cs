// Ensure the 'MyMath' namespace is defined and accessible in your project.
// If the 'Rooter' class is in a different project, add a reference to that project in your test project.
// Right-click on the test project in Solution Explorer, select "Add Reference", and add the project containing 'MyMath'.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// Replace 'MyMath' with the correct namespace where the 'Rooter' class is defined.
using MyMath; // Ensure this namespace is correct and matches the one where 'Rooter' is defined.

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter(); // Ensure 'Rooter' is defined in the 'MyMath' namespace or referenced correctly.
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void RooterTestPositiveInput()
        {
            double input = 25.0;
            double expected = 5.0;
            Rooter rooter = new Rooter(); // Ensure 'Rooter' is defined in the 'MyMath' namespace or referenced correctly.
            double actual = rooter.SquareRoot(input);

            Assert.IsTrue(Math.Abs(actual - expected) < 0.001, "Square root calculation is incorrect.");
        }
    }
}
