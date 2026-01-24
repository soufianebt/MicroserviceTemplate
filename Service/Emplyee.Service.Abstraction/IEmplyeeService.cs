namespace Emplyee.Service.Abstraction
{
    public interface IEmplyeeService
    {
        IEnumerable<Model.Emplyee> GetAll();
        void Add(Model.Emplyee projectName);
        IQueryable<Model.Emplyee> Query();
    }
}
