using System.Collections.Generic;

namespace CodeQuality.NetStandard
{
    internal class Poco
    {
        internal static IEnumerable<DeveloperModel> Create => new List<DeveloperModel>()
            {
                new DeveloperModel{IsDeveloperWorking = false,
                Name = "Volkan", Rate = 10},

                new DeveloperModel{IsDeveloperWorking = true,
                Name = "RC", Rate = 1}
            };
    }
}
