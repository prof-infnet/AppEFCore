using AppEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppEFCore.Controllers
{
    public class UpdateController : Controller
    {
        private CompanyContext context;

        public UpdateController(CompanyContext cc)
        {
            context = cc;
        }

        public async Task<IActionResult> UpdateSingle()
        {
            var dept = new Department()
            {
                Id = 1,
                Name = "Research"
            };

            context.Update(dept);
            await context.SaveChangesAsync();
            return View("Common");
        }

        public async Task<IActionResult> UpdateRelated()
        {
            var dept = new Department()
            {
                Id = 5,
                Name = "Admin_1"
            };

            var emp = new Employee()
            {
                Id = 1,
                Name = "Matt_1",
                Designation = "Head_1",
                Department = dept
            };
            context.Update(emp);
            await context.SaveChangesAsync();
            return View("Common");
        }


    }
}
