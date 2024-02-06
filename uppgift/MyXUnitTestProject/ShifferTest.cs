using System.Runtime.CompilerServices;
using Xunit;

public class ShifferTest

{
    [Fact]
    public void TestAdd()
    {
        Shiffer shiff = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        int result = shiff.Add(a, b);

        Assert.Equal(expectedResult, result);

    }

}