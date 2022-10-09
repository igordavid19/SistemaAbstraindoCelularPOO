namespace SistemaAbstraindoCelularPOO.Models
{
    public static class TorreDeTelefone
    {
        private static bool TemSinal = true;

        public static bool VerificarSinal()
        {
            return TemSinal;
        }

        public static void AlternarSinal()
        {
            TemSinal = !TemSinal;
        }
    }
}