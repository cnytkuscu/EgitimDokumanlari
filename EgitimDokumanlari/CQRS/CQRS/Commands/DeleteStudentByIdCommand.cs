using CQRS.CQRS.Results;
using MediatR;

namespace CQRS.CQRS.Commands
{
    public class DeleteStudentByIdCommand : IRequest<DeleteStudentByIdCommandResult>
    {
        public int Id { get; set; }

        public DeleteStudentByIdCommand(int id)
        {
            Id = id;
        }
    }
}
