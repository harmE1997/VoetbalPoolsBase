namespace VoetbalPoolsBase.Interfaces
{
    public interface IHost
    {
        Dictionary<string, Topscorer> GetTopscorers();
    }
}
