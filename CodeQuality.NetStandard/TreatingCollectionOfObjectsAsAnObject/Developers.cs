using System.Collections.Generic;
using System.Linq;

namespace CodeQuality.NetStandard
{
    public class Developers : IDevelopers
    {
        private IEnumerable<DeveloperModel> ListOfDevelopersDeveloper { get; set; }

        public Developers(IEnumerable<DeveloperModel> listOfDevelopersDeveloper)
        {
            ListOfDevelopersDeveloper = listOfDevelopersDeveloper;
        }

        public IDevelopers GetAvailable() => new Developers(ListOfDevelopersDeveloper.Where(x => !x.IsDeveloperWorking));

        public IDevelopers OrderByRateDescending() => new Developers(ListOfDevelopersDeveloper.OrderByDescending(o => o.Rate));
    }
}
