namespace Deportes.Models
{
    public enum Genero
    {
        Masculino,
        Femenino,
        NoBinario
    }

    public static class GeneroExtensions
    {
        public static Genero FromString(this Genero value, string param)
        {
            if (string.IsNullOrEmpty(param))
            {
                return Genero.NoBinario;
            }

            // Definimos los conjuntos de opciones posibles para cada género.
            HashSet<string> opcionesMasculino = new HashSet<string>() { "hombre", "h", "m", "masculino" };
            HashSet<string> opcionesFemenino = new HashSet<string>() { "mujer", "f", "femenino" };

            param = param.ToLower();

            if (opcionesMasculino.Contains(param))
            {
                return Genero.Masculino;
            }
            else if (opcionesFemenino.Contains(param))
            {
                return Genero.Femenino;
            }
            else
            {
                return Genero.NoBinario;
            }
        }
    }
}
