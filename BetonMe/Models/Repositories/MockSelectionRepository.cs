using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    public class MockSelectionRepository : ISelectionRepository
    {
        private readonly IMarketRepository _marketRepository = new MockMarketRepository();

        public IEnumerable<Selection> AllSelections =>
            new List<Selection>
            {
                new Selection {Id = 1, Name = "First Selection", Odds = 1.80F, Result = Result.Win, Market = _marketRepository.GetMarketById(1)},
                new Selection {Id = 2, Name = "Second Selection", Odds = 2.40F, Result = Result.Lose, Market = _marketRepository.GetMarketById(1)},
                new Selection {Id = 3, Name = "Third Selection", Odds = 2.80F, Result = Result.Lose, Market = _marketRepository.GetMarketById(1)},

                new Selection {Id = 4, Name = "Fourth Selection", Odds = 1.02F, Result = Result.None, Market = _marketRepository.GetMarketById(2)},
                new Selection {Id = 5, Name = "Fifth Selection", Odds = 41.0F, Result = Result.None, Market = _marketRepository.GetMarketById(2)},
                new Selection {Id = 6, Name = "Sixth Selection", Odds = 100.0F, Result = Result.None, Market = _marketRepository.GetMarketById(2)},

                new Selection {Id = 7, Name = "Over", Odds = 1.80F, Result = Result.Lose, Market = _marketRepository.GetMarketById(3)},
                new Selection {Id = 8, Name = "Under", Odds = 1.80F, Result = Result.Void, Market = _marketRepository.GetMarketById(3)},
            };

        public Selection GetSelectionById(int selectionId)
        {
            return AllSelections.FirstOrDefault(s => s.Id == selectionId);
        }
    }
}
