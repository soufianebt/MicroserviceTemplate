namespace ProjectName.Model
{
    public class AppSettings
    {
        public ConnectionStrings connectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string ProjectNameDb { get; set; }
    }
}
