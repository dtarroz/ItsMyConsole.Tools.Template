namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Option de configuration pour SWAPI
    /// </summary>
    public class SwapiOption
    {
        /// <summary>
        /// Nombre de résultat maximum pour la recherche de personnage.<br/>
        /// Valeur entre 1 et 10 inclus.
        /// </summary>
        public int MaxResultSearchPeople { get; set; } = 10;
    }
}
