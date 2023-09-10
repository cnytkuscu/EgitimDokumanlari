using CQRS.CQRS.Results;
using MediatR;

namespace CQRS.CQRS.Queries
{
    public class GetAllStudentQuery : IRequest<IEnumerable<GetAllStudentQueryResult>>
    {
    }
}
