namespace SiennaAidHub.Models
{
    public class SiennaDatabaseSettings : ISiennaDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISiennaDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}