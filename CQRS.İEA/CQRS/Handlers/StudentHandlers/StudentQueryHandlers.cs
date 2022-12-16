using CQRS.İEA.CQRS.Results.StudentResults;
using CQRS.İEA.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.İEA.CQRS.Handlers.StudentHandlers
{
    public class StudentQueryHandlers
    {
        private readonly ProductContext _context;

        public StudentQueryHandlers(ProductContext context)
        {
            _context = context;
        }
        public List<GetStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetStudentQueryResult
            {
                StudentID = x.StudentID,
                Name = x.Name,
                Surname = x.Surname,
                City = x.City
            }).ToList();
            return values;
        }
    }
}
