using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using ManagementSystem.Data;

public class UserController : Controller
{
    private readonly AppDbContext _userService;

    public UserController()
    {
        _userService = new AppDbContext(unitOfWork);
    }

    public IActionResult Index(string role)
    {
        var roles = new List<string> { "Admin", "Manager", "Salesman" };
        ViewBag.Roles = new SelectList(roles);

        var users = _userService.GetUsers(role);
        return View(users);
    }
}