using Model.Domain;

namespace Model.DAL
{
	public class SQLiteRepository<T> : IRepository<T> where T : class, IDomainObject, new()
	{
		private readonly EFContext db = new();
		public void Add(T entity)
		{
			db.Add(entity);
			this.Save();
		}

		public void Delete(T entity)
		{
			db.Remove(entity);
			this.Save();
		}

		public IEnumerable<T> GetAll() => db.Set<T>();

		public void Save()
		{
			db.SaveChanges();
		}

		public void Update(IList<T> values)
		{
			db.UpdateRange(values);
			this.Save();
		}
	}
}
