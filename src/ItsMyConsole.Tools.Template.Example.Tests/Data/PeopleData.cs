using System.Collections;
using System.Collections.Generic;

namespace ItsMyConsole.Tools.Template.Example.Tests.Data;

public class PeopleData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator() {
        List<object[]> peoples = new List<object[]> {
            GetSearchE(),
            GetSearchAh(),
            GetSearchSky(),
            GetSearchNotExists()
        };
        return peoples.GetEnumerator();
    }

    private static object[] GetSearchE() {
        List<People> peoples = new List<People> {
            new() {
                Id = 1,
                Name = "Luke Skywalker"
            },
            new() {
                Id = 4,
                Name = "Darth Vader"
            },
            new() {
                Id = 5,
                Name = "Leia Organa"
            },
            new() {
                Id = 6,
                Name = "Owen Lars"
            },
            new() {
                Id = 7,
                Name = "Beru Whitesun lars"
            },
            new() {
                Id = 9,
                Name = "Biggs Darklighter"
            },
            new() {
                Id = 10,
                Name = "Obi-Wan Kenobi"
            },
            new() {
                Id = 11,
                Name = "Anakin Skywalker"
            },
            new() {
                Id = 13,
                Name = "Chewbacca"
            },
            new() {
                Id = 15,
                Name = "Greedo"
            }
        };
        return new object[] { 10, "e", peoples };
    }

    private static object[] GetSearchAh() {
        List<People> peoples = new List<People> {
            new() {
                Id = 13,
                Name = "Darth Vader"
            },
            new() {
                Id = 7,
                Name = "Beru Whitesun lars"
            },
            new() {
                Id = 9,
                Name = "Biggs Darklighter"
            },
            new() {
                Id = 9,
                Name = "Wilhuff Tarkin"
            },
            new() {
                Id = 13,
                Name = "Chewbacca"
            }
        };
        return new object[] { 5, "a h", peoples };
    }

    private static object[] GetSearchSky() {
        List<People> peoples = new List<People> {
            new() {
                Id = 1,
                Name = "Luke Skywalker"
            },
            new() {
                Id = 11,
                Name = "Anakin Skywalker"
            },
            new() {
                Id = 43,
                Name = "Shmi Skywalker"
            }
        };
        return new object[] { 4, "sky", peoples };
    }

    private static object[] GetSearchNotExists() {
        List<People> peoples = new List<People>();
        return new object[] { 1, "Not Exists", peoples };
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
