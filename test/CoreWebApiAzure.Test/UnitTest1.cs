using CoreWebApiAzure.Controllers;

namespace CoreWebApiAzure.Test;


/// Unit Test

public class UnitTest1
{
    ValuesController objValController = new ValuesController(); /// Arrange

    [Fact] ///Arrange, Act,Assert
    public void Test1()
    {
        var result = objValController.Get('1'); ///Act
        Assert.Equal("value1", result);
    }
}