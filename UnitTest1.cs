using System.Formats.Asn1;

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
    //super algorithm
    //it's funny because the iterative one is faster in EVERY test I made
    public static int superAlgorithm(int exponent)
    {
        return iterativePowerOf2(exponent);
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
    }
}
