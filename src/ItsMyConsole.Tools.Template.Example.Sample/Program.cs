using ItsMyConsole;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ItsMyConsole.Tools.Template.Example;

// ReSharper disable once CheckNamespace
namespace MyExampleConsole
{
    class Program
    {
        static async Task Main() {
            ConsoleCommandLineInterpreter ccli = new ConsoleCommandLineInterpreter();

            // Console configuration
            ccli.Configure(options => {
                options.Prompt = ">> ";
                options.LineBreakBetweenCommands = true;
                options.HeaderText = "###########\n#  SWAPI  #\n###########\n";
                options.TrimCommand = true;
            });

            // SWAPI configuration
            ccli.ConfigureSwapi(new SwapiOption { MaxResultSearchPeople = 10 });

            // Display the name of peoples
            // Example : people sky
            ccli.AddCommand("^people (.+)$", RegexOptions.IgnoreCase, async tools => {
                string name = tools.CommandMatch.Groups[1].Value;
                List<People> peoples = await tools.Swapi().SearchPeople(name);
                if (peoples.Count > 0)
                    foreach (People people in peoples)
                        Console.WriteLine(people.Name);
                else
                    Console.WriteLine("Aucune personne trouvée");
            });

            await ccli.RunAsync();
        }
    }
}
