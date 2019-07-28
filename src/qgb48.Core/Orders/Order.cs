using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace qgb48.Orders
{
    [Table("Order", Schema = "blogging")]
   // public class Order : AbpRepositoryBase<Order, int>, ICreationAudited
    public class Order :AggregateRoot, IRepository<Order>, ICreationAudited,IOrder
    {
          //  [NotMapped]
          //private IRepository<Order> _repository { get; set; }
          //  public Order(IRepository<Order> repository)
          //  {
          //      _repository = repository;
          //  }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set ; }
        public List<OrderItem> OrderItem { get; set; }
        public string Remark { get; set; }
        public Address Address { get; set; }

        public Order Insert(Order entity)
        {
            return entity;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Order FirstOrDefault(int id)
        {
            throw new NotImplementedException();
        }

        public Order FirstOrDefault(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Order> FirstOrDefaultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> FirstOrDefaultAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAllIncluding(params Expression<Func<Order, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllList(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllListAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        
        public int InsertAndGetId(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndGetIdAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> InsertAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order InsertOrUpdate(Order entity)
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdateAndGetId(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertOrUpdateAndGetIdAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> InsertOrUpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Load(int id)
        {
            throw new NotImplementedException();
        }

        public long LongCount()
        {
            throw new NotImplementedException();
        }

        public long LongCount(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<Order>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public Order Single(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Order> SingleAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Update(int id, Action<Order> updateAction)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(int id, Func<Order, Task> updateAction)
        {
            throw new NotImplementedException();
        }
    }
}
