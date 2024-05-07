using DemoGuid.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoGuid.Controllers
{
    public class DepartmentsController : Controller
    {
        static List<Department> DepartmentsFirstLoad = DataInitializer.SeedDepartment();
        public IActionResult Index()
        {
            var departments = DepartmentsFirstLoad;
            return View(departments);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var department = DepartmentsFirstLoad.Find(d => d.Id == id);
            return View(department);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var department = DepartmentsFirstLoad.Find(d => d.Id == id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department dep)
        {
            var department = DepartmentsFirstLoad.Find(d => d.Id == dep.Id);
            if (department == null)
            {
                return NotFound();
            }
            department.Name = dep.Name;
            return RedirectToAction("Index");

        }

        [HttpGet]
        [ActionName("Verwijder")]
        public IActionResult Delete(Department dep)
        {
            var found = DepartmentsFirstLoad.Find(d => d.Id == dep.Id);
            if (found == null)
            {
                return NotFound();
            }
            DepartmentsFirstLoad.Remove(found);
            return RedirectToAction("Index");
        }

        [HttpGet]


public IActionResult Create()

        {

            //var nextId = DepartmentsFirstLoad.Count + 1;

            ViewBag.Id = Guid.NewGuid();

            return View();

        }

        [HttpPost]

        public IActionResult Create(Department department)

        {

            

            DepartmentsFirstLoad.Add(department);

            return RedirectToAction("Index");

        }
    }
}
