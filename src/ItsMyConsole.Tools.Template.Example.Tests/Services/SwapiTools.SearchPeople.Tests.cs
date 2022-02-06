using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ItsMyConsole.Tools.Template.Example.Tests.Asserts;
using ItsMyConsole.Tools.Template.Example.Tests.Data;
using Xunit;

namespace ItsMyConsole.Tools.Template.Example.Tests.Services;

public class SwapiTools_SearchPeople_Tests
{
    [Fact]
    public async Task SearchPeople_Null() {
        SwapiTools swapiTools = new SwapiTools(new SwapiOption());

        await Assert.ThrowsAsync<ArgumentNullException>(() => swapiTools.SearchPeople(null));
    }

    [Fact]
    public async Task SearchPeople_Empty() {
        SwapiTools swapiTools = new SwapiTools(new SwapiOption());

        await Assert.ThrowsAsync<ArgumentException>(() => swapiTools.SearchPeople(""));
    }

    [Theory]
    [ClassData(typeof(PeopleData))]
    public async Task SearchPeople_Valid(int maxResultSearchPeople, string name, List<People> peoples) {
        SwapiOption swapiOption = new SwapiOption { MaxResultSearchPeople = maxResultSearchPeople };
        SwapiTools swapiTools = new SwapiTools(swapiOption);

        List<People> searchPeoples = await swapiTools.SearchPeople(name);

        PeopleAssert.Equal(peoples, searchPeoples);
    }
}
