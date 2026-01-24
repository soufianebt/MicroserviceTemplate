using Emplyee.Dal.Abstraction;
using Emplyee.Data;

namespace Emplyee.Dal.Imp
{
    public class EmplyeeDal : IEmplyeeDal
    {
        private readonly EmplyeeContext _projectNameContext;

        public EmplyeeDal(EmplyeeContext projectNameContext)
        {
            this._projectNameContext = projectNameContext;
        }

        public void Add(Model.Emplyee projectName)
        {
            _projectNameContext.Emplyees.Add(projectName);
            _projectNameContext.SaveChanges();
        }

        public IEnumerable<Model.Emplyee> GetAll()
        {
            return _projectNameContext.Emplyees.ToList();
        }

        public IQueryable<Model.Emplyee> Query()
        {
            return _projectNameContext.Emplyees;
        }
    }
}
