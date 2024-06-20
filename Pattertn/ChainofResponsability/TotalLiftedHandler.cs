using Deportes.Models;

namespace Deportes.Pattertn.ChainofResponsability
{
    public class TotalLiftedHandler : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(WeightliftingScoreRequest request, WeightliftingScoreResponse response)
        {
            //Logica de este eslabon de  la cadena
            response.TotalLifted = request.Arranque + request.Envion;

            //Call al Next() ->
            _nextHandler?.Handle(request, response);
        }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
