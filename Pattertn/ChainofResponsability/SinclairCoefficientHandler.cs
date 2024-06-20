using Deportes.Models;

namespace Deportes.Pattertn.ChainofResponsability
{
    public class SinclairCoefficientHandler : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(WeightliftingScoreRequest request, WeightliftingScoreResponse response)
        {
            response.SinclairCoefficient = ObtenerCoeficienteSinclair(request.PesoCorporal, request.Genero);
            _nextHandler?.Handle(request, response);
        }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        private double ObtenerCoeficienteSinclair(double pesoCorporal, string genero)
        {
            var gender = Genero.NoBinario.FromString(genero);
            double a = 0;

            switch (gender)
            {
                case Genero.Masculino:
                    a = 0.73;
                    break;
                case Genero.Femenino:
                    a = 0.78;
                    break;
                case Genero.NoBinario:
                    // Aquí puedes decidir cómo manejar los casos no binarios.
                    // Para este ejemplo, usamos un promedio entre los coeficientes masculino y femenino.
                    a = (.78 + 0.72) / 2;
                    break;
            }

            double logTerm = Math.Log10(pesoCorporal / a);
            double coeficiente = Math.Pow(10, a * logTerm * logTerm);

            return coeficiente;
        }
    }
}
