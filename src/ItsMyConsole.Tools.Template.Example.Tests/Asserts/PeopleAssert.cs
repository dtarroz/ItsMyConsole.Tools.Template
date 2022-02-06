using System.Collections.Generic;
using Xunit;

namespace ItsMyConsole.Tools.Template.Example.Tests.Asserts;

public static class PeopleAssert
{
    public static void Equal(List<People> expected, List<People> actual) {
        Assert.NotNull(expected);
        Assert.NotNull(actual);
        Assert.Equal(expected.Count, actual.Count);
        for (int i = 0; i < expected.Count; i++)
            Equal(expected[i], actual[i]);
    }

    private static void Equal(People expected, People actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
    }
}
