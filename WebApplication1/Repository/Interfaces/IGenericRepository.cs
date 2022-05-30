namespace Concecionaria.Repository.Interfaces
{
	public interface IGenericRepository<T>
	{
		IEnumerable<T> GetAll();
		T GetById(int? id);
		void Insert(T entity);	
		void Update(T entity);
		void Delete(int? entity);




	}
}
