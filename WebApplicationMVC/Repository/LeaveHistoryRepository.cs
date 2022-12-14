using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.Contracts;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository 
    {
        private readonly ApplicationDbContext _db;
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
           _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
          return  _db.LeaveHistories.ToList();
        }

        public LeaveHistory FindById(int id)
        {
           return _db.LeaveHistories.Find(id);
        }

        public ICollection<LeaveHistory> GetEmployeesByLeaveHistory(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.Update(entity);
            return Save();
        }
    }
}
