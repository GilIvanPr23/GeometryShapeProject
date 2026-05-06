namespace GeometryShapeLib.Tests;

using Xunit;
using GeometryShapeLib.Models;

public class RectangleTests
{
    [Fact]
    public void ZeroHeightDataToArea()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.height = 0;
        rectangle.width = 10;

        Assert.Throws<ArgumentException>(() => rectangle.Area());
    }
    [Fact]
    public void CorrectDataToArea()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.height = 10;
        rectangle.width = 10;
        double result = 100;

        Assert.Equal(result, rectangle.Area());
    }
    [Fact]
    public void CorrectDataToPerimeter()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.height = 10;
        rectangle.width = 10;
        double result = 40;

        Assert.Equal(result, rectangle.Perimeter());
    }

    [Fact]
    public void ZeroHeightDataToPerimeter()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.height = 0;
        rectangle.width = 10;

        Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
    }
}
