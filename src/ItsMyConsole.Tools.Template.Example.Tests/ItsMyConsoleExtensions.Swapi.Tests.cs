using System;
using System.Reflection;
using Xunit;

namespace ItsMyConsole.Tools.Template.Example.Tests;

public class ItsMyConsoleExtensions_Swapi_Tests
{
    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    public void Swapi_Valid(int maxResultSearchPeople) {
        ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();
        CommandTools commandTools = CreateNewCommandTools();
        SwapiOption swapiOption = new SwapiOption { MaxResultSearchPeople = maxResultSearchPeople };

        ccli.ConfigureSwapi(swapiOption);
        SwapiTools swapiTools = commandTools.Swapi();

        Assert.NotNull(swapiTools);
        Assert.Equal(maxResultSearchPeople, swapiTools.GetMaxResultSearchPeople());
    }

    private static CommandTools CreateNewCommandTools() {
        const BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Instance;
        ConstructorInfo constructorInfo = typeof(CommandTools).GetConstructor(bindingFlags, Type.EmptyTypes);
        return (CommandTools)constructorInfo?.Invoke(null);
    }
}
