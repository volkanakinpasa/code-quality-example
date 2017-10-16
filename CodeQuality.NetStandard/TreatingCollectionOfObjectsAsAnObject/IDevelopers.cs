namespace CodeQuality.NetStandard
{
    public interface IDevelopers
    {
        IDevelopers GetAvailable();
        IDevelopers OrderByRateDescending();
    }
}
