using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TaskManagmentWithRazorPages.Pages.Duties.ViewModels;

namespace TaskManagmentWithRazorPages.Pages.Duties
{
    public class IndexModel : PageModel
    {
        IDutyRepository _dutyRepository;
        public IList<Duty> _duties;
        public IndexModel(IDutyRepository dutyRepository)
        {
            _dutyRepository = dutyRepository;
        }

        public async Task OnGetAsync()
        {
            _duties = await _dutyRepository.GetAllAsync();

        }

        public PartialViewResult OnGetAddDutyPartial()
        {
            VMDuty vmduty = new VMDuty();
          
            return new PartialViewResult
            {
                ViewName = "_AddDuty",
                ViewData = new ViewDataDictionary<VMDuty>(ViewData,  vmduty)
            };
        }

        public async Task<IActionResult> OnPostAddDuty(VMDuty vmduty)
        {
            if (vmduty.Title != null && vmduty.Description!=null)
            {


                Duty NewDuty = new Duty()
                {
                    Title = vmduty.Title,
                    Description = vmduty.Description,
                    CreatedDate = DateTime.Now,
                    NextActionDate = vmduty.NextActionDate,
                    RequiredBy = vmduty.RequiredBy,
                    Type = (DutyType)vmduty.Type,
                    Status = (DutyStatus)vmduty.Status,

                };

                _dutyRepository.AddAsync(NewDuty);
            }
            return RedirectToPage();
        }
    }
}
