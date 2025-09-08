using Microsoft.AspNetCore.Mvc;
using MVC_One.Data;
using Microsoft.EntityFrameworkCore;

namespace MVC_One.Controllers
{
    public class TasksController : Controller
    {
        private readonly MVC_OneContext _context;

        public TasksController(MVC_OneContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var TasksList = await _context.Tasks.ToListAsync();
            return View(TasksList);
        }



//      List<Models.TaskModel>  TasksList = new List<Models.TaskModel>{
//            new Models.TaskModel {Id=1, Name = "Task in a list", Progress = 80 },
//            new Models.TaskModel {Id=2, Name = "Another Task in a list", Progress = 20 },
//            new Models.TaskModel {Id=3, Name = "Third Task in a list", Progress = 50 }
//};
//        public IActionResult Overview()
//        {
//            var task = new Models.TaskModel() {};
//            return View(task);
//        }

//        public IActionResult GetAll()
//        {
//            return View(TasksList.ToArray());
//            //return Json(new {Tasks = TasksList.ToArray()});
//        }

//        public IActionResult GetTask(int id)
//        {
//            var TargetTask = TasksList.Find(t => t.Id == id);

//            if(TargetTask == null)
//            {
//                return View("NotFound");
//            }

//            return Json(new { Task = TargetTask });
//        }
    }
}
