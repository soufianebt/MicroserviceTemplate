
namespace ProjectName.Dal.Abstraction
{
    public interface IProjectNameDal
    {
        void Add(Model.ProjectName projectName);
        IEnumerable<Model.ProjectName> GetAll();
    }
}
