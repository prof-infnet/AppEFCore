using AppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppEFCore.Controllers
{
    public class InsertController : Controller
    {
        private CompanyContext context;

        public InsertController(CompanyContext cc)
        {
            context = cc;
        }
        public async Task<IActionResult> InsertSingle()
        {
            var dept = new Department()
            {
                Name = "Designing"
            };

            // Destacando Estados do Context
            //context.Entry(dept).State = EntityState.Added;
            //context.SaveChanges();

            context.Add(dept);
            await context.SaveChangesAsync();


            return View("Common");
        }

        public async Task<IActionResult> InsertMultiple()
        {
            var dept1 = new Department() { Name = "Development" };
            var dept2 = new Department() { Name = "HR" };
            var dept3 = new Department() { Name = "Marketing" };

            var depts = new List<Department>() { dept1, dept2, dept3 };

            context.AddRange(depts);
            await context.SaveChangesAsync();

            return View("Common");
        }

        public async Task<IActionResult> InsertRelated()
        {
            var dept = new Department()
            {
                Name = "Admin"
            };

            var emp = new Employee()
            {
                Name = "Matt",
                Designation = "Head",
                Department = dept
            };

            context.Add(emp);
            await context.SaveChangesAsync();

            return View("Common");

        }
    }
}
