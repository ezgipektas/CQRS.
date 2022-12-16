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
        private readonly UpdateStudentCommandHandler _updatestudentcommandHandler;

        public StudentController(StudentQueryHandlers studentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, UpdateStudentCommandHandler updatestudentcommandHandler)
        {
            _studentQueryHandler = studentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _updatestudentcommandHandler = updatestudentcommandHandler;
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
        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            var values=_getStudentByIDQueryHandler.Handle(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult GetStudent(UpdateStudentCommand command)
        {
            _updatestudentcommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveStudent(int id)
        {
            _removeStudentCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }
    }
}
