using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.Contracts;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Repository
{
   
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;   
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
            //
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
            //
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            return _db.LeaveTypes.Find(id);
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
          return  _db.SaveChanges() >0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
            //
        }
    }
}
