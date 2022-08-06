using Microsoft.AspNetCore.Mvc;
using TestTaskOnSea.Models;
using TestTaskOnSea.UnitOfWork.Interfaces;

namespace TestTaskOnSea.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(User user)
        {
            _unitOfWork.userRepository.AddUser(user);
            await _unitOfWork.SaveAsync();
            return RedirectToAction("SignIn");
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _unitOfWork.userRepository.GetAllAsync();
            return Ok(users);
        }
    }
}
