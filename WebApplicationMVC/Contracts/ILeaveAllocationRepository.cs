using System.Collections.Generic;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Contracts
{
    public interface ILeaveAllocationRepository: IRepositoryBase<LeaveAllocation>
    {
        ICollection<LeaveAllocation> GetEmployeesByLeaveAllocation(int id);

    }
}
