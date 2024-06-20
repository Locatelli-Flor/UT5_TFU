using Deportes.Models;

namespace Deportes.Pattertn.ChainofResponsability
{
    public class ScoreCalculationHandler : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(WeightliftingScoreRequest request, WeightliftingScoreResponse response)
        {
            response.Score = response.TotalLifted * response.SinclairCoefficient;
            _nextHandler?.Handle(request, response);
        }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
