using System.Collections.Generic;

namespace CodeQuality.NetStandard
{
    internal class Poco
    {
        internal static IEnumerable<DeveloperModel> Create => new List<DeveloperModel>()
            {
                new DeveloperModel{IsDeveloperWorking = true,
                Name = "Volkan", Rate = 10},

                new DeveloperModel{IsDeveloperWorking = false,
                Name = "RC", Rate = 1}
            };
    }
}
