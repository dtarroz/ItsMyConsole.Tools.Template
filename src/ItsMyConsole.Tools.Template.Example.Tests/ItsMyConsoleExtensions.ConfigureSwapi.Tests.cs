using System;
using Xunit;

namespace ItsMyConsole.Tools.Template.Example.Tests;

public class ItsMyConsoleExtensions_ConfigureSwapi_Tests
{
    [Fact]
    public void ConfigureSwapi_ArgumentNullException() {
        ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();

        Assert.Throws<ArgumentNullException>(() => ccli.ConfigureSwapi(null));
    }

    [Fact]
    public void ConfigureSwapi_Empty() {
        ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();

        ccli.ConfigureSwapi(new SwapiOption());
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(11)]
    public void ConfigureSwapi_ArgumentException(int maxResultSearchPeople) {
        ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();
        SwapiOption swapiOption = new SwapiOption { MaxResultSearchPeople = maxResultSearchPeople };

        Assert.Throws<ArgumentOutOfRangeException>(() => ccli.ConfigureSwapi(swapiOption));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    public void ConfigureSwapi_Valid(int maxResultSearchPeople) {
        ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();
        SwapiOption swapiOption = new SwapiOption { MaxResultSearchPeople = maxResultSearchPeople };

        ccli.ConfigureSwapi(swapiOption);
    }
}
