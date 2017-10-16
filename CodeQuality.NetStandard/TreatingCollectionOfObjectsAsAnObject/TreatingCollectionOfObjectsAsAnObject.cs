using System.Collections.Generic;

namespace CodeQuality.NetStandard
{
    public class TreatingCollectionOfObjectsAsAnObject
    {
        public void Run()
        {
            IEnumerable<DeveloperModel> developersModel = Poco.Create;

            IDevelopers developers = new Developers(developersModel);

            Start(developers);
        }

        private void Start(IDevelopers developers)
        {
            //We only need available developers with in order
            var availableAndOrdered = developers.GetAvailable().OrderByRateDescending();

            //We need all developers(available or not) with in order
            var ordered = developers.OrderByRateDescending();
        }
    }
}
