using Xunit;

namespace ItsMyConsole.Tools.Template.Example.Tests.Models;

public class SwapiOption_Tests
{
    [Fact]
    public void SwapiOption_Valid() {
        SwapiOption swapiOption = new SwapiOption();

        Assert.Equal(10, swapiOption.MaxResultSearchPeople);
    }
}
