using ProjectName.Dal.Abstraction;
using ProjectName.Data;

namespace ProjectName.Dal.Imp
{
    public class ProjectNameDal : IProjectNameDal
    {
        private readonly ProjectNameContext _projectNameContext;

        public ProjectNameDal(ProjectNameContext projectNameContext)
        {
            this._projectNameContext = projectNameContext;
        }

        public void Add(Model.ProjectName projectName)
        {
            _projectNameContext.ProjectNames.Add(projectName);
            _projectNameContext.SaveChanges();
        }

        public IEnumerable<Model.ProjectName> GetAll()
        {
            return _projectNameContext.ProjectNames.AsEnumerable();
        }
    }
}
