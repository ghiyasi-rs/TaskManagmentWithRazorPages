using Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TaskManagmentWithRazorPages.Pages.Duties.ViewModels
{
    public class VMDuty
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequiredBy { get; set; } = DateTime.Now.Date;
        public string Description { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public List<UserList> AssignedTo { get; set; }
        public int[] UserIds { get; set; }
        public List<SelectListItem> Users { get; set; }
       
        public DateTime NextActionDate { get; set; } = DateTime.Now.Date;
    }
}
