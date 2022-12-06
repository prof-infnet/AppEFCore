using AppEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppEFCore.Controllers
{
    public class ReadController : Controller
    {

        private CompanyContext context;

        public ReadController(CompanyContext cc)
        {
            context = cc;
        }
        public async Task<IActionResult> ReadSingle()
        {
            //ReadSingle
            // var emp = await context.Employees
            //.Where(e => e.Name == "Matt")
            //.FirstOrDefaultAsync();

            // List
            // var emps = await context.Employees.ToListAsync ();

            // Eager Loading
            //Employee emp = await context.Employees
              //  .Where(e => e.Name == "Will")
                //.Include(s => s.Department)
                //.FirstOrDefaultAsync();





            return View("Common");
        }
    }
}
