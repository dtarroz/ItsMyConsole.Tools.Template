using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Outils pour SWAPI
    /// </summary>
    public class SwapiTools
    {
        private readonly SwapiOption _swapiOption;
        static readonly HttpClient _httpClient = new HttpClient();

        internal SwapiTools(SwapiOption swapiOption) {
            _swapiOption = swapiOption;
        }

        /// <summary>
        /// Récupération du nombre de résultat maximum pour la recherche de personnages
        /// </summary>
        public int GetMaxResultSearchPeople() {
            return _swapiOption.MaxResultSearchPeople;
        }

        /// <summary>
        /// Recherche des personnages à partir d'un nom
        /// </summary>
        /// <param name="name">Le nom des personnages à chercher</param>
        public async Task<List<People>> SearchPeople(string name) {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name == "")
                throw new ArgumentException(nameof(name), "Le nom est obligatoire");
            List<People> peoples = new List<People>();
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/people?search={name}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic responseJson = JsonConvert.DeserializeObject(responseBody);
            foreach (dynamic people in responseJson.results)
                peoples.Add(new People {
                                Id = GetId(people),
                                Name = people.name
                            });
            return peoples.Take(_swapiOption.MaxResultSearchPeople).ToList();
        }

        private static int GetId(dynamic people) {
            string url = people.url;
            return Convert.ToInt32(url.Substring(29).TrimEnd('/'));
        }
    }
}
