using CQRS.İEA.CQRS.Queries.StudentQueries;
using CQRS.İEA.CQRS.Results.StudentResults;
using CQRS.İEA.DAL.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRS.İEA.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetStudentByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetStudentByIDQueryResult Handle(int id)
        {
            var values = _productContext.Students.Find(id);
            return new GetStudentByIDQueryResult
            {
                City = values.City,
                LessonAverage = values.LessonAverage,
                Name = values.Name,
                StudentID = values.StudentID,
                Surname = values.Surname
            };
        }
    }
}
