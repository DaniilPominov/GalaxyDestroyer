using GalaxyDestroyer;

namespace Tests
{
    [TestClass]
    public class DestroyerTests
    {
        #region Calculator test
        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(5, Destroyer.Calculator("2+3"));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(-1, Destroyer.Calculator("2-3"));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(6, Destroyer.Calculator("2*3"));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, Destroyer.Calculator("6/3"));
        }

        [TestMethod]
        public void TestOperatorPrecedence_MultiplicationBeforeAddition()
        {
            Assert.AreEqual(14, Destroyer.Calculator("3*4+2"));
        }

        [TestMethod]
        public void TestOperatorPrecedence_DivisionBeforeSubtraction()
        {
            Assert.AreEqual(2, Destroyer.Calculator("10/2-3"));
        }

        [TestMethod]
        public void TestDecimalNumbers()
        {
            Assert.AreEqual(9, Destroyer.Calculator("2.5*3+1.5"));
        }

        [TestMethod]
        public void TestNegativeNumbers()
        {
            Assert.AreEqual(1, Destroyer.Calculator("-5+3*2"));
        }

        [TestMethod]
        public void TestExpressionWithSpaces()
        {
            Assert.AreEqual(5, Destroyer.Calculator(" 2 + 3 "));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyInput_ThrowsArgumentException()
        {
            Destroyer.Calculator("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidOperator_ThrowsArgumentException()
        {
            Destroyer.Calculator("2&3");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero_ThrowsDivideByZeroException()
        {
            Destroyer.Calculator("5/0");
        }
        #endregion
        
        #region Abs Tests

        [TestMethod]
        public void Abs_DoublePositive_ReturnsSameValue()
        {
            double result = Destroyer.Abs(5.5);
            Assert.AreEqual(5.5, result);
        }

        [TestMethod]
        public void Abs_DoubleNegative_ReturnsPositiveValue()
        {
            double result = Destroyer.Abs(-3.7);
            Assert.AreEqual(3.7, result);
        }

        [TestMethod]
        public void Abs_DoubleZero_ReturnsZero()
        {
            double result = Destroyer.Abs(0.0);
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void Abs_IntPositive_ReturnsSameValue()
        {
            int result = Destroyer.Abs(10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Abs_IntNegative_ReturnsPositiveValue()
        {
            int result = Destroyer.Abs(-7);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Abs_IntZero_ReturnsZero()
        {
            int result = Destroyer.Abs(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Abs_StringValidNumber_ReturnsAbsoluteValue()
        {
            string result = Destroyer.Abs("-15.3");
            Assert.AreEqual("15.3", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Abs_StringInvalidNumber_ThrowsArgumentException()
        {
            Destroyer.Abs("invalid");
        }

        #endregion

        #region Add Tests

        [TestMethod]
        public void Add_DoubleNumbers_ReturnsSum()
        {
            double result = Destroyer.Add(2.5, 3.5);
            Assert.AreEqual(6.0, result);
        }

        [TestMethod]
        public void Add_IntNumbers_ReturnsSum()
        {
            int result = Destroyer.Add(4, 5);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Add_StringValidNumbers_ReturnsSumAsString()
        {
            string result = Destroyer.Add("3.2", "1.8");
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_StringInvalidNumbers_ThrowsArgumentException()
        {
            Destroyer.Add("a", "2");
        }

        #endregion

        #region Subtract Tests

        [TestMethod]
        public void Subtract_DoubleNumbers_ReturnsDifference()
        {
            double result = Destroyer.Subtract(5.5, 2.5);
            Assert.AreEqual(3.0, result);
        }

        [TestMethod]
        public void Subtract_IntNumbers_ReturnsDifference()
        {
            int result = Destroyer.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_StringValidNumbers_ReturnsDifferenceAsString()
        {
            string result = Destroyer.Subtract("7.5", "2.5");
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Subtract_StringInvalidNumbers_ThrowsArgumentException()
        {
            Destroyer.Subtract("x", "1");
        }

        #endregion

        #region Multiply Tests

        [TestMethod]
        public void Multiply_DoubleNumbers_ReturnsProduct()
        {
            double result = Destroyer.Multiply(2.5, 4.0);
            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void Multiply_IntNumbers_ReturnsProduct()
        {
            int result = Destroyer.Multiply(3, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiply_StringValidNumbers_ReturnsProductAsString()
        {
            string result = Destroyer.Multiply("2.5", "4");
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Multiply_StringInvalidNumbers_ThrowsArgumentException()
        {
            Destroyer.Multiply("a", "3");
        }

        #endregion

        #region Divide Tests

        [TestMethod]
        public void Divide_DoubleNumbers_ReturnsQuotient()
        {
            double result = Destroyer.Divide(10.0, 2.0);
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DoubleByZero_ThrowsDivideByZeroException()
        {
            Destroyer.Divide(5.0, 0.0);
        }

        [TestMethod]
        public void Divide_IntNumbers_ReturnsQuotient()
        {
            int result = Destroyer.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_IntByZero_ThrowsDivideByZeroException()
        {
            Destroyer.Divide(5, 0);
        }

        [TestMethod]
        public void Divide_StringValidNumbers_ReturnsQuotientAsString()
        {
            string result = Destroyer.Divide("10", "2");
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_StringByZero_ThrowsDivideByZeroException()
        {
            Destroyer.Divide("5", "0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_StringInvalidNumbers_ThrowsArgumentException()
        {
            Destroyer.Divide("a", "2");
        }

        #endregion

        #region Power Tests

        [TestMethod]
        public void Power_DoubleNumbers_ReturnsResult()
        {
            double result = Destroyer.Power(2.0, 3.0);
            Assert.AreEqual(8.0, result, 0.0001);
        }

        [TestMethod]
        public void Power_DoubleNegativeExponent_ReturnsFraction()
        {
            double result = Destroyer.Power(2.0, -1.0);
            Assert.AreEqual(0.5, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Power_ZeroToNegativeExponent_ThrowsDivideByZeroException()
        {
            Destroyer.Power(0.0, -1.0);
        }

        [TestMethod]
        public void Power_IntNumbers_ReturnsResult()
        {
            int result = Destroyer.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Power_IntNegativeExponent_ThrowsDivideByZeroException()
        {
            Destroyer.Power(2, -1);
        }

        [TestMethod]
        public void Power_StringValidNumbers_ReturnsResultAsString()
        {
            string result = Destroyer.Power("2", "3");
            Assert.AreEqual("8", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Power_StringInvalidNumbers_ThrowsArgumentException()
        {
            Destroyer.Power("a", "2");
        }

        #endregion

        #region SquareRoot Tests

        [TestMethod]
        public void SquareRoot_DoubleNumber_ReturnsResult()
        {
            double result = Destroyer.SquareRoot(25.0);
            Assert.AreEqual(5.0, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_DoubleNegative_ThrowsArgumentException()
        {
            Destroyer.SquareRoot(-1.0);
        }

        [TestMethod]
        public void SquareRoot_IntNumber_ReturnsResult()
        {
            int result = Destroyer.SquareRoot(25);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_IntNegative_ThrowsArgumentException()
        {
            Destroyer.SquareRoot(-1);
        }

        [TestMethod]
        public void SquareRoot_StringValidNumber_ReturnsResultAsString()
        {
            string result = Destroyer.SquareRoot("25");
            var res = Convert.ToDouble(result);
            double epsilon = 0.0001;
            Assert.IsTrue((res-5.0)<=epsilon);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_StringInvalidNumber_ThrowsArgumentException()
        {
            Destroyer.SquareRoot("a");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_StringNegativeNumber_ThrowsArgumentException()
        {
            Destroyer.SquareRoot("-1");
        }

        #endregion

        #region SuperSum test
        [TestMethod]
    public void SuperSum_Double_ValidConcatenation_ReturnsParsedDouble()
    {
        double a = 12.3;
        double b = 4.56;

        double result = Destroyer.SuperSum(a, b);

        Assert.AreEqual(124.56, result, 0.1); 
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SuperSum_Double_InvalidConcatenation_ThrowsArgumentException()
    {
        double a = double.NaN;
        double b = double.PositiveInfinity;

        Destroyer.SuperSum(a, b);
    }

    [TestMethod]
    public void SuperSum_Int_ValidConcatenation_ReturnsParsedInt()
    {
        int a = 123;
        int b = 456;

        double result = Destroyer.SuperSum(a, b);

        Assert.AreEqual((double)123456, result);
    }
    }
    #endregion
}