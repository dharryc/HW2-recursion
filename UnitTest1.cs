using System.Formats.Asn1;
using BenchmarkDotNet.Toolchains.Mono;

namespace tests;

public class Algorithms
{
    //problem 1
    public static int pow(int exponent, int bas)
    {
        if (exponent == 0)
            return 1;
        else
            return bas * pow(exponent - 1, bas);
    }
    //problem 2
    public static int triangle(int n)
    {
        if (n == 1)
            return 1;
        else
            return triangle(n - 1) + n;
    }
    public static int iterativePowerOf2(int exponent)
    {
        int answer = 2;
        if (exponent == 0)
        {
            return 1;
        }
        else
        {
            for (int a = 1; a < exponent; a++)
            {
                answer = 2 * answer;
            }
            return answer;
        }
    }
    public static int recursivePowerOf2(int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else
        {
            return 2 * recursivePowerOf2(exponent - 1);
        }
    }

    public static int superAlgorithm(int exponent)
    {
        if (exponent <= 23)
            return iterativePowerOf2(exponent);
        else
            return fastPowerOf2(exponent);
    }

    public static int recMinIndex(int[] array)
    {
        int arrayLength = array.Length;
        int minLocation = 0;
        int minValue = array[minLocation];
        for (int a = 0; a < arrayLength; a++)
        {
            if (array[a] < minValue)
            {
                minValue = array[a];
                minLocation = a;
            }
        }
        return minLocation;
    }
    public static int getGCD(int big, int small)
    {
        if (big % small == 0)
        {
            return small;
        }
        else
        {
            return getGCD(small, big % small);
        }
    }

    //I know it wanted me to print the answer, but instead I have it returning the int[] so that I can test it
    public static int[] simplifyFraction(int big, int small)
    {
        int[] a = { 0, 0 };
        a[0] = big / getGCD(big, small);
        a[1] = small / getGCD(big, small);
        return a;
    }
    public static int fastPowerOf2(int n)
    {
        if (n == 0)
            return 1;
        else if (isEven(n))
            return square(fastPowerOf2(n / 2));
        else
            return 2 * fastPowerOf2(n - 1);
    }
    public static int square(int n)
    {
        return n * n;
    }
    public static bool isEven(int n)
    {
        if (n % 2 == 0)
            return true;
        else
            return false;
    }
}

public class UnitTest1
{
    [Fact]
    public void WhenExponentIs1ThenReturnsBase()
    {
        //problem 1 tests
        Assert.Equal(5, Algorithms.pow(1, 5));
        Assert.Equal(8 * 8 * 8, Algorithms.pow(3, 8));
        //problem 2 tests
        Assert.Equal(45, Algorithms.triangle(9));
        Assert.Equal(630, Algorithms.triangle(35));
        //problem 5 iterative test
        Assert.Equal(512, Algorithms.iterativePowerOf2(9));
        Assert.Equal(1, Algorithms.iterativePowerOf2(0));
        Assert.Equal(32768, Algorithms.iterativePowerOf2(15));
        //problem 5 recursive test
        Assert.Equal(512, Algorithms.iterativePowerOf2(9));
        Assert.Equal(1, Algorithms.iterativePowerOf2(0));
        Assert.Equal(32768, Algorithms.iterativePowerOf2(15));
        //problem 3 minIndex test
        int[] array1 = { 5, 8, 33, 1, 97, 5, 3, 3, 3, 3 };
        int[] array2 = { 5, 8, 33, 43, 97, 5, 3, 3, 1, 3 };
        Assert.Equal(3, Algorithms.recMinIndex(array1));
        Assert.Equal(8, Algorithms.recMinIndex(array2));
        //problem 4 deviding test split into testing the GCD finder and the acutal full function
        Assert.Equal(3, Algorithms.getGCD(186, 81));
        Assert.Equal(7, Algorithms.getGCD(28, 7));
        //actual simplifying test
        int[] fraction1 = { 62, 27 };
        int[] fraction2 = { 4, 1 };
        Assert.Equal(fraction1, Algorithms.simplifyFraction(186, 81));
        Assert.Equal(fraction2, Algorithms.simplifyFraction(28, 7));
        //fastPowerOf2 tests!
        Assert.Equal(64, Algorithms.fastPowerOf2(6));
        Assert.Equal(32768, Algorithms.fastPowerOf2(15));
    }
}
