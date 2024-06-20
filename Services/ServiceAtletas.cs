using Deportes.Models;

namespace Deportes.Services
{
    public class ServiceAtletas
    {
        public List<Atlete> Atletas()
        {
            List<string> deportesOlimpicos = new List<string>
                {
                    "Atletismo",
                    "Natación",
                    "Gimnasia artística",
                    "Ciclismo (ruta y pista)",
                    "Esgrima",
                    "Remo",
                    "Voleibol (y voleibol de playa)",
                    "Boxeo",
                    "Baloncesto",
                    "Tenis"
                };

            List<Atlete> atletas = new List<Atlete>();
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                Atlete atleta = new Atlete
                {
                    Name = "Atleta " + i,
                    Id_ticket = "ID  # " + i.ToString("D3"),
                    Disciplina = deportesOlimpicos[random.Next(deportesOlimpicos.Count)]
                };
                atletas.Add(atleta);
            }

            return atletas;
        }
    }
}
