using FluentAssertions;
using Xunit;

namespace BowlingKata.Tests;

public class MyClassTests
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var myClass = new MyClass();
        
        //Act
        var result = myClass.Hello();

        //Assert
        result.Should().Be("Hello World!");
    }
}
