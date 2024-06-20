using Deportes.Models;

namespace Deportes.Pattertn.ChainofResponsability
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(WeightliftingScoreRequest request, WeightliftingScoreResponse response);
    }
}
