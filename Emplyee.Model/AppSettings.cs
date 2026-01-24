namespace Emplyee.Model
{
    public class AppSettings
    {
        public ConnectionStrings connectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string? EmplyeeDb { get; set; }
    }
}
