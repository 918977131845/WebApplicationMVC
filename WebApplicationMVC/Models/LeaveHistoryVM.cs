using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }

        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public Employee ApprovedBy { get; set; }
        public string ApprovedById { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}
