using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTRazorDivCheckRadioDrpDown24.MockData;
using TTTRazorDivCheckRadioDrpDown24.Models;

namespace TTTRazorDivCheckRadioDrpDown24.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private ITeacherService _teacherService;

        private List<Teacher> _teachers;

        public List<Teacher> Teachers => _teachers;

        public IndexModel(ITeacherService teacherService)
        {
            this._teacherService = teacherService;
        }
        public void OnGet()
        {
            _teachers = _teacherService.Teachers;
        }
    }
}
