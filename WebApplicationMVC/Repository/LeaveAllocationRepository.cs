using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.Contracts;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocation.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocation.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
           return _db.LeaveAllocation.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
           return _db.LeaveAllocation.Find(id);

        }

        public ICollection<LeaveAllocation> GetEmployeesByLeaveAllocation(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.Update(entity); 
            return Save();
        }
    }
}
