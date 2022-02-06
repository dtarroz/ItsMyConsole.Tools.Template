namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Les informations d'une personne
    /// </summary>
    public class People
    {
        internal People() { }

        /// <summary>
        /// L'identifiant de la personne
        /// </summary>
        public int Id { get; internal set; }

        /// <summary>
        /// Le nom de la personne
        /// </summary>
        public string Name { get; internal set; }
    }
}
