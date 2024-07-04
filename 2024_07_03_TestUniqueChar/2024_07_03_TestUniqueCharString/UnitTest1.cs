namespace _2024_07_03_TestUniqueCharString;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string someString = "abc";
        var result = TestNamespace.UniqueCharString.IsUniqueCharString(someString);
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        string someString = "abcc";
        var result = TestNamespace.UniqueCharString.IsUniqueCharString2(someString);
        Assert.True(result == false);
    }
}