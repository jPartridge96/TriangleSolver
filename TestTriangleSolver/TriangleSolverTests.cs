using NUnit.Framework;
using TriangleSolver;

namespace TestTriangleSolver
{
    [TestFixture]
    public class TriangleSolverTests
    {
        Triangle t = new Triangle();

        #region EQUILATERAL
        [Test]
        public void triangle_a5b5c5_expectEquilateral()
        {
            // Arrange
            int a = 5;
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            // Act
            string actual = t.AnalyzeTriangle(a, a, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
