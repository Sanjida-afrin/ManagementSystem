using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{

   
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string role)
        {
            // Send the roles to the view for dropdown
            var roles = new List<string> { "Admin", "Manager", "Salesman" };
            ViewBag.Roles = roles;

            // Filter users by role
            var users = string.IsNullOrEmpty(role)
                ? _context.Users.ToList()
                : _context.Users.Where(u => u.Role == role).ToList();

            return View(users);
        }
   
}
