using System.Collections.Generic;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Contracts
{
    public interface ILeaveTypeRepository: IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
