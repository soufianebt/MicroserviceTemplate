using ProjectName.Dal.Abstraction;
using ProjectName.Service.Abstraction;

namespace ProjectName.Service.Imp
{
    public class ProjectNameService : IProjectNameService
    {
        private readonly IProjectNameDal _projectNameDal;

        public ProjectNameService(IProjectNameDal projectNameDal)
        {
            this._projectNameDal = projectNameDal;
        }

        public void Add(Model.ProjectName projectName)
        {
            _projectNameDal.Add(projectName);
        }

        public IEnumerable<Model.ProjectName> GetAll()
        {
            return _projectNameDal.GetAll();
        }
    }
}
