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

        #region ISOSCELES
        [Test]
        public void triangle_a5b5c2_expectIsosceles()
        {
            // Arrange
            int a = 5;
            int b = 2;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = t.AnalyzeTriangle(a, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a5b2c5_expectIsosceles()
        {
            // Arrange
            int a = 5;
            int b = 2;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = t.AnalyzeTriangle(a, b, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a2b5c5_expectIsosceles()
        {
            // Arrange
            int a = 5;
            int b = 2;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = t.AnalyzeTriangle(b, a, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
