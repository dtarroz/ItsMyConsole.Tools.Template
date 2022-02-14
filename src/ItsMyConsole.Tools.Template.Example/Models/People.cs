namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Les informations d'un personnage
    /// </summary>
    public class People
    {
        internal People() { }

        /// <summary>
        /// L'identifiant du personnage
        /// </summary>
        public int Id { get; internal set; }

        /// <summary>
        /// Le nom de la personnage
        /// </summary>
        public string Name { get; internal set; }
    }
}
