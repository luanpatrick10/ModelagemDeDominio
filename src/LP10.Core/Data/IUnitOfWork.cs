namespace LP10.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }

}
