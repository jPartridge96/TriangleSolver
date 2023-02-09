using NUnit.Framework;
using System.Runtime.InteropServices;
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

        #region SCALENE
        [Test]
        public void triangle_a1b2c3_expectScalene()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = t.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a2b3c1_expectScalene()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = t.AnalyzeTriangle(b, c, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a3b1c2_expectScalene()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = t.AnalyzeTriangle(c, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a1b3c2_expectScalene()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = t.AnalyzeTriangle(a, c, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a2b1c3_expectScalene()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = t.AnalyzeTriangle(b, a, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region ZERO
        [Test]
        public void triangle_a0b1c1_expectZero()
        {
            // Arrange
            int a = 0;
            int b = 1;
            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = t.AnalyzeTriangle(a, b, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a1b0c1_expectZero()
        {
            // Arrange
            int a = 0;
            int b = 1;
            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = t.AnalyzeTriangle(b, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a1b1c0_expectZero()
        {
            // Arrange
            int a = 0;
            int b = 1;
            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = t.AnalyzeTriangle(b, b, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region INVALID_RESPONSE
        [Test]
        public void triangle_aN1b1c1_expectInvalid()
        {
            // Arrange
            int a = -1;
            int b = 1;
            string expected = "Based on the values entered, the triangle is INVALID";

            // Act
            string actual = t.AnalyzeTriangle(a, b, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a1bN1c1_expectInvalid()
        {
            // Arrange
            int a = -1;
            int b = 1;
            string expected = "Based on the values entered, the triangle is INVALID";

            // Act
            string actual = t.AnalyzeTriangle(b, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void triangle_a1b1cN1_expectInvalid()
        {
            // Arrange
            int a = -1;
            int b = 1;
            string expected = "Based on the values entered, the triangle is INVALID";

            // Act
            string actual = t.AnalyzeTriangle(b, b, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
