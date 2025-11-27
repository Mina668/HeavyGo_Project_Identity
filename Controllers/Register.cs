using Microsoft.AspNetCore.Mvc;

public class RegisterController : Controller
{
    public IActionResult ChooseRole()
    {
        return View(); 
    }
}
