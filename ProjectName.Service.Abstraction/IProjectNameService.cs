namespace ProjectName.Service.Abstraction
{
    public interface IProjectNameService
    {
        IEnumerable<Model.ProjectName> GetAll();
        void Add(Model.ProjectName projectName);

    }
}
