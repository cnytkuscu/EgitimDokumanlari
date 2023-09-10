using CQRS.CQRS.Queries;
using CQRS.CQRS.Results;
using CQRS.Data;
using Microsoft.EntityFrameworkCore;

namespace CQRS.CQRS.Handlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly StudentContext _context;

        public GetAllStudentQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public IEnumerable<GetAllStudentQueryResult> Handle(GetAllStudentQuery query)
        {
            var students = _context.Students.Select(x => new GetAllStudentQueryResult
            {
                Name = x.Name,
                Surname = x.Surname
            }).AsNoTracking().AsEnumerable();

            return students;
        }
    }
}
