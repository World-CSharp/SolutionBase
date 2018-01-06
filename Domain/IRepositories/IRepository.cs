using Domain.Entities;

namespace Domain.IRepositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        #region Get
        //TEntity Get(int id);
        //TEntity First();
        //IQueryable<TEntity> Get();
        TEntity GetByID(object id);
        #endregion

        #region Add
        ///TEntity Add(TEntity obj);
        ///List<TEntity> AddAll(IEnumerable<TEntity> obj);
        void Insert(TEntity entity);
        #endregion

        #region Update
        //void Update(TEntity obj);
        void Update(TEntity entityToUpdate);
        #endregion

        #region Delete
        ///void DeleteAll(IEnumerable<TEntity> obj);
        ///void Delete(TEntity obj);
        ///void Delete(int id);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        #endregion
    }
}
