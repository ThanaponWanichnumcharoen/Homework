namespace Test_Homework;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double value = Program.ConvertStringToDouble("5120.25");
        Assert.IsType<double>(value);
    }
}