using Deportes.Models;

namespace Deportes.Pattertn.ChainofResponsability
{
    public class AlterofiliaChain
    {


        IHandler Start { get; set; }

        public AlterofiliaChain()
        {
            Reset();
        
        }
        private void Reset()
        {
            var totalLiftedHandler = new TotalLiftedHandler();
            this.Start = totalLiftedHandler;
            var sinclairCoefficientHandler = new SinclairCoefficientHandler();
            var scoreCalculationHandler = new ScoreCalculationHandler();
            //configuro el chain
            totalLiftedHandler.SetNext(sinclairCoefficientHandler);
            sinclairCoefficientHandler.SetNext(scoreCalculationHandler);
        }

        public void Handle(WeightliftingScoreRequest request, WeightliftingScoreResponse response)
        {
            Start.Handle(request, response);
        }
    }
}
