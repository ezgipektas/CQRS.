using CQRS.İEA.CQRS.Commands.StudentCommands;
using CQRS.İEA.CQRS.Handlers.StudentHandlers;
using CQRS.İEA.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.İEA.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentQueryHandlers _studentQueryHandler;
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;

        public StudentController(StudentQueryHandlers studentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler)
        {
            _studentQueryHandler = studentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
        }

        public StudentController(GetStudentByIDQueryHandler getStudentByIDQueryHandler)
        {
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _studentQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult GetStudent(int id)
        {
            var values=_getStudentByIDQueryHandler.Handle(id);
            return View(values);
        }
        public IActionResult RemoveStudent(int id)
        {
            _removeStudentCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }
    }
}
