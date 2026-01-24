using Emplyee.Dal.Abstraction;
using Emplyee.Service.Abstraction;

namespace Emplyee.Service.Imp
{
    public class EmplyeeService : IEmplyeeService
    {
        private readonly IEmplyeeDal _projectNameDal;

        public EmplyeeService(IEmplyeeDal projectNameDal)
        {
            this._projectNameDal = projectNameDal;
        }

        public void Add(Model.Emplyee projectName)
        {
            _projectNameDal.Add(projectName);
        }

        public IEnumerable<Model.Emplyee> GetAll()
        {
            return _projectNameDal.GetAll();
        }

        public IQueryable<Model.Emplyee> Query()
        {
            return _projectNameDal.Query();
        }
    }
}
