using CQRS.İEA.CQRS.Commands.StudentCommands;
using CQRS.İEA.DAL.Context;
using CQRS.İEA.DAL.Entities;

namespace CQRS.İEA.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;
        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.studentName,
                Surname = command.studentSurname,
                Department = command.studentDepartment
            });
            _context.SaveChanges();
        }
    }
}
