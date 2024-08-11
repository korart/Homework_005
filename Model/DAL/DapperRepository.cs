using Dapper;
using Model.Domain;
using System.Data.SQLite;

namespace Model.DAL
{
	public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject, new()
	{
		private readonly SQLiteConnection db = new SQLiteConnection("Data Source = employees.db;");
		public void Add(T entity)
		{
			string sql = "INSERT INTO Employees (Name, Age) VALUES (@Name, @Age)";
			db.Execute(sql, entity);
		}

		public void Delete(T entity)
		{
			string sql = "DELETE FROM Employees WHERE Id = @Id";
			db.Execute(sql, entity);
		}

		public IEnumerable<T> GetAll()
		{
			return db.Query<T>("SELECT * FROM Employees;");
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public void Update(IList<T> values)
		{
			// Ничего не меняем, поэтому собственно не понятно какие поля обновлять
			throw new NotImplementedException();
		}
	}
}
