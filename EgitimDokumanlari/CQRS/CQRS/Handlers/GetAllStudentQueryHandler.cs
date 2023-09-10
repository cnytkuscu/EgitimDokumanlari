using CQRS.CQRS.Queries;
using CQRS.CQRS.Results;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.CQRS.Handlers
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<GetAllStudentQueryResult>>
    {

        private readonly StudentContext _context;

        public GetAllStudentQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllStudentQueryResult>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.Select(x => new GetAllStudentQueryResult { Name = x.Name, Surname = x.Surname }).AsNoTracking().ToListAsync();
        }

       


    }
}
