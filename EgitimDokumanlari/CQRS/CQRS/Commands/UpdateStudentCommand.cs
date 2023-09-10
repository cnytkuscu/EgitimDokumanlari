using CQRS.CQRS.Results;
using MediatR;

namespace CQRS.CQRS.Commands
{
    public class UpdateStudentCommand : IRequest<UpdateStudentCommandResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
