using AppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppEFCore.Controllers
{
    public class DeleteController : Controller
    {
        private CompanyContext context;

        public DeleteController(CompanyContext cc)
        {
            context = cc;
        }

        public async Task<IActionResult> DeleteSingle()
        {
            var dept = new Department()
            {
                Id = 7
            };

            context.Remove(dept);
            await context.SaveChangesAsync();
            return View("Common");
        }

        public async Task<IActionResult> DeleteCascade()
        {
            Department dept = context.Departments
                .Where(a => a.Id == 5)
                .Include(x => x.Employee)
                .FirstOrDefault();

            context.Remove(dept);
            await context.SaveChangesAsync();

            return View("Common");
        }
    }
}
