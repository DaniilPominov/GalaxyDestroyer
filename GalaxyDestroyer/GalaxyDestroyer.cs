namespace GalaxyDestroyer;

/// <summary>
/// Provides mathematical operations for different numeric types including double, int and string representations.
/// Includes basic arithmetic operations, power functions and square root calculations.
/// </summary>
public class Destroyer
{

    /// <summary>
    /// Performs a "super sum" operation by converting the first number to an integer, 
    /// then concatenating it with the string representation of the second number,
    /// and parsing the result as a double.
    /// </summary>
    /// <param name="a">The first double value to be converted to integer before concatenation.</param>
    /// <param name="b">The second double value to be concatenated.</param>
    /// <returns>The parsed result of the concatenated values as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when:
    /// - The first value cannot be converted to a 32-bit integer (overflow)
    /// - The concatenated result cannot be parsed as a double
    /// </exception>
    /// <remarks>
    /// The method first attempts to convert the first parameter to a 32-bit integer.
    /// If successful, it concatenates this integer with the string representation
    /// of the second parameter and attempts to parse the result as a double.
    /// </remarks>
    public static double SuperSum(double a, double b)
    {
        try
        {
            var intA = Convert.ToInt32(a);
        }
        catch (OverflowException ex)
        {
            throw new ArgumentException("Concatenated value is not a valid double.");
        }

        if (int.TryParse(Convert.ToInt32(a).ToString(), out var aInteger))
        {
            if (double.TryParse(aInteger.ToString() + b.ToString(), out var result))
                return result;
        }
        throw new ArgumentException("Concatenated value is not a valid double.");
    }

    /// <summary>
    /// Concatenates the string representations of two integers, parses the result, and returns it as a double.
    /// </summary>
    /// <param name="a">The first integer value.</param>
    /// <param name="b">The second integer value.</param>
    /// <returns>The parsed result of concatenated string representations of a and b.</returns>
    /// <exception cref="ArgumentException">Thrown when the concatenated string cannot be parsed as an integer.</exception>
    public static double SuperSum(int a, int b)
    {
        if (double.TryParse(a.ToString() + b.ToString(), out var result))
            return result;
        throw new ArgumentException("Concatenated value is not a valid integer.");
    }

    /// <summary>
    /// Concatenates two strings and returns the combined result as double.
    /// </summary>
    /// <param name="a">The first string.</param>
    /// <param name="b">The second string.</param>
    /// <returns>The concatenation of a and b.</returns>
    public static double SuperSum(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return SuperSum(numA,numB);
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Returns the absolute value of a double-precision floating-point number.
    /// </summary>
    /// <param name="a">The number to get the absolute value of.</param>
    /// <returns>
    /// The absolute value of a. If a is positive, returns a unchanged.
    /// If a is negative, returns -a. Returns 0 if a is 0.
    /// </returns>
    public static double Abs(double a)
    {
        if (a > 0)
        {
            return a;
        }
        return -a;  // Fixed: should return -a for negative numbers
    }

    /// <summary>
    /// Returns the absolute value of a 32-bit integer.
    /// </summary>
    /// <param name="a">The integer to get the absolute value of.</param>
    /// <returns>
    /// The absolute value of a. If a is positive, returns a unchanged.
    /// If a is negative, returns -a. Returns 0 if a is 0.
    /// </returns>
    public static int Abs(int a)
    {
        if (a > 0)
        {
            return a;
        }
        return -a;  // Fixed: should return -a for negative numbers
    }

    /// <summary>
    /// Returns the absolute value of a numeric string after parsing it to a number.
    /// </summary>
    /// <param name="a">The numeric string to get the absolute value of.</param>
    /// <returns>
    /// The absolute value of the parsed number as a string.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the string cannot be parsed to a valid number.
    /// </exception>
    public static string Abs(string a)
    {
        if (double.TryParse(a, out var numA))
            return Abs(numA).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }
    /// <summary>
    /// Adds two double-precision floating-point numbers.
    /// </summary>
    /// <param name="a">The first number to add.</param>
    /// <param name="b">The second number to add.</param>
    /// <returns>The sum of a and b.</returns>
    public static double Add(double a, double b) => a + b;

    /// <summary>
    /// Adds two 32-bit integers.
    /// </summary>
    /// <param name="a">The first integer to add.</param>
    /// <param name="b">The second integer to add.</param>
    /// <returns>The sum of a and b.</returns>
    public static int Add(int a, int b) => a + b;

    /// <summary>
    /// Adds two numeric strings after parsing them to numbers.
    /// </summary>
    /// <param name="a">The first numeric string to add.</param>
    /// <param name="b">The second numeric string to add.</param>
    /// <returns>The sum of parsed numbers as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when strings cannot be parsed to numbers.</exception>
    public static string Add(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA + numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Subtracts one double-precision floating-point number from another.
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The result of subtracting b from a.</returns>
    public static double Subtract(double a, double b) => a - b;

    /// <summary>
    /// Subtracts one 32-bit integer from another.
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The result of subtracting b from a.</returns>
    public static int Subtract(int a, int b) => a - b;

    /// <summary>
    /// Subtracts two numeric strings after parsing them to numbers.
    /// </summary>
    /// <param name="a">The minuend numeric string.</param>
    /// <param name="b">The subtrahend numeric string.</param>
    /// <returns>The difference of parsed numbers as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when strings cannot be parsed to numbers.</exception>
    public static string Subtract(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA - numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Multiplies two double-precision floating-point numbers.
    /// </summary>
    /// <param name="a">The first factor.</param>
    /// <param name="b">The second factor.</param>
    /// <returns>The product of a and b.</returns>
    public static double Multiply(double a, double b) => a * b;

    /// <summary>
    /// Multiplies two 32-bit integers.
    /// </summary>
    /// <param name="a">The first factor.</param>
    /// <param name="b">The second factor.</param>
    /// <returns>The product of a and b.</returns>
    public static int Multiply(int a, int b) => a * b;

    /// <summary>
    /// Multiplies two numeric strings after parsing them to numbers.
    /// </summary>
    /// <param name="a">The first factor numeric string.</param>
    /// <param name="b">The second factor numeric string.</param>
    /// <returns>The product of parsed numbers as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when strings cannot be parsed to numbers.</exception>
    public static string Multiply(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA * numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Divides one double-precision floating-point number by another.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of a divided by b.</returns>
    /// <exception cref="DivideByZeroException">Thrown when b is zero.</exception>
    public static double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed");
        return a / b;
    }

    /// <summary>
    /// Divides one 32-bit integer by another.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of a divided by b.</returns>
    /// <exception cref="DivideByZeroException">Thrown when b is zero.</exception>
    public static int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed");
        return a / b;
    }

    /// <summary>
    /// Divides two numeric strings after parsing them to numbers.
    /// </summary>
    /// <param name="a">The dividend numeric string.</param>
    /// <param name="b">The divisor numeric string.</param>
    /// <returns>The quotient of parsed numbers as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when strings cannot be parsed to numbers.</exception>
    /// <exception cref="DivideByZeroException">Thrown when b is zero.</exception>
    public static string Divide(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
        {
            if (numB == 0) throw new DivideByZeroException("Division by zero is not allowed");
            return (numA / numB).ToString();
        }
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Raises a double-precision floating-point number to a specified power.
    /// </summary>
    /// <param name="a">The base.</param>
    /// <param name="b">The exponent.</param>
    /// <returns>The result of raising a to the power of b.</returns>
    /// <exception cref="DivideByZeroException">Thrown when base is zero and exponent is negative.</exception>
    public static double Power(double a, double b)
    {
        if (a == 0 && b < 0) throw new DivideByZeroException("Zero cannot be raised to a negative power");

        double result = 1;
        bool negativeExponent = b < 0;
        int iterations = (int)Abs(b);
        double remaining = Abs(b) - iterations;

        for (int i = 0; i < iterations; i++)
        {
            result *= a;
        }

        if (remaining > 0)
        {
            double x = remaining * Math.Log(a);
            double approx = 1 + x + (x * x) / 2 + (x * x * x) / 6;
            result *= approx;
        }

        return negativeExponent ? 1 / result : result;
    }

    /// <summary>
    /// Raises a 32-bit integer to a specified non-negative integer power.
    /// </summary>
    /// <param name="a">The base.</param>
    /// <param name="b">The non-negative exponent.</param>
    /// <returns>The result of raising a to the power of b.</returns>
    /// <exception cref="DivideByZeroException">Thrown when exponent is negative.</exception>
    public static int Power(int a, int b)
    {
        if (b < 0) throw new DivideByZeroException("Integer power doesn't support negative exponents");

        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }

    /// <summary>
    /// Raises a numeric string to the power of another numeric string after parsing them to numbers.
    /// </summary>
    /// <param name="a">The base numeric string.</param>
    /// <param name="b">The exponent numeric string.</param>
    /// <returns>The result of raising parsed a to the power of parsed b as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when strings cannot be parsed to numbers.</exception>
    public static string Power(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return Power(numA, numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    /// <summary>
    /// Calculates the square root of a double-precision floating-point number using Babylonian method.
    /// </summary>
    /// <param name="a">The number to calculate square root of.</param>
    /// <returns>The square root of a.</returns>
    /// <exception cref="ArgumentException">Thrown when a is negative.</exception>
    public static double SquareRoot(double a)
    {
        if (a < 0) throw new ArgumentException("Square root of negative number is not defined");
        if (a == 0) return 0;

        double epsilon = 0.000001;
        double guess = a / 2.0;

        while (Abs(guess * guess - a) > epsilon)
        {
            guess = (guess + a / guess) / 2.0;
        }

        return guess;
    }

    /// <summary>
    /// Calculates the integer square root of a 32-bit integer using binary search.
    /// </summary>
    /// <param name="a">The number to calculate square root of.</param>
    /// <returns>The largest integer less than or equal to the exact square root of a.</returns>
    /// <exception cref="ArgumentException">Thrown when a is negative.</exception>
    public static int SquareRoot(int a)
    {
        if (a < 0) throw new ArgumentException("Square root of negative number is not defined");
        if (a == 0) return 0;

        int left = 1, right = a, result = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mid <= a / mid)
            {
                left = mid + 1;
                result = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    /// <summary>
    /// Calculates the square root of a numeric string after parsing it to a number.
    /// </summary>
    /// <param name="a">The numeric string to calculate square root of.</param>
    /// <returns>The square root of parsed number as a string.</returns>
    /// <exception cref="ArgumentException">Thrown when string cannot be parsed to a number or is negative.</exception>
    public static string SquareRoot(string a)
    {
        if (double.TryParse(a, out var num))
            return SquareRoot(num).ToString();
        throw new ArgumentException("String must contain a valid number");
    }
}