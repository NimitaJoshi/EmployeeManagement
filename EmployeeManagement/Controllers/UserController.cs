using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagement.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            return View(UserRepository.users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            ViewBag.header = "Create User";
            return View();
        }

        //POST: UserController/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                UserRepository.create(user);
                return View("Index", UserRepository.users);
            }
            else
                return View();
        }

        public ActionResult Delete(int id)
        {
            UserRepository.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {

            ViewBag.header = "Update User";  //Pass the header value to Index view
            User? selectedUser = UserRepository.users.Where(x => x.Id == id).FirstOrDefault();
            return View(selectedUser);
        }

        //POST: UserController/Update
        [HttpPost]
        public ActionResult Update(User user, int id)
        {
            UserRepository.update(user, id);
            return RedirectToAction("Index");
        }

        //Display data using JSON action
        public JsonResult MyUserlistJsonResult()
        {
            return Json(UserRepository.users);
        }

       
    }
}
