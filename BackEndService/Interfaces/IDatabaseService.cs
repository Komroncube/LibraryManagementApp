namespace managementcheck.Interfaces
{
    public interface IDatabaseService<T> where T : class
    {
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(Guid Id);
        public abstract IEnumerable<T> GetAll();
        public abstract int GetCount();
    }
}
