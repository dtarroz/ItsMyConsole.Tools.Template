namespace ItsMyConsole.Tools.Template.Example
{
    /// <summary>
    /// Extension de ItsMyConsole pour inclure les outils SWAPI
    /// </summary>
    public static class ItsMyConsoleExtensions
    {
        private static readonly SwapiOption SwapiOption = new SwapiOption();

        /// <summary>
        /// Configuration de SWAPI pour son utilisation pendant l'exécution d'une ligne de commande
        /// </summary>
        /// <param name="ccli">La console qui configure SWAPI</param>
        /// <param name="swapiOption">Les options pour SWAPI</param>
        public static void ConfigureSwapi(this ConsoleCommandLineInterpreter ccli, SwapiOption swapiOption) { }

        /// <summary>
        /// L'accès à SWAPI
        /// </summary>
        /// <param name="commandTools">Les outils de commandes pour accéder à SWAPI</param>
        public static SwapiTools Swapi(this CommandTools commandTools) {
            return null;
        }
    }
}
