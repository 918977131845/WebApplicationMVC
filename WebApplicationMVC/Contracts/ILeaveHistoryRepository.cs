using System.Collections.Generic;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Contracts
{
    public interface ILeaveHistoryRepository:IRepositoryBase<LeaveHistory>
    {
        ICollection<LeaveHistory> GetEmployeesByLeaveHistory(int id);
    }
}
