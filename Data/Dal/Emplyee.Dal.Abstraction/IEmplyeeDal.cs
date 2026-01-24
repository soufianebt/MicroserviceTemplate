namespace Emplyee.Dal.Abstraction
{
    public interface IEmplyeeDal
    {
        void Add(Model.Emplyee projectName);
        IEnumerable<Model.Emplyee> GetAll();
        IQueryable<Model.Emplyee> Query();
    }
}
