using CQRS.İEA.DAL.Context;

namespace CQRS.İEA.CQRS.Handlers.StudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;
        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(int id)
        {
            var values = _context.Students.Find(id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
