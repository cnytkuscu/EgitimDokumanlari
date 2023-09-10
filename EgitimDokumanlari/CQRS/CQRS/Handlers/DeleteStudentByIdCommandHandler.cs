using CQRS.CQRS.Commands;
using CQRS.CQRS.Results;
using CQRS.Data;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS.CQRS.Handlers
{
    public class DeleteStudentByIdCommandHandler : IRequestHandler<DeleteStudentByIdCommand, DeleteStudentByIdCommandResult>
    {

        private readonly StudentContext _studentContext;

        public DeleteStudentByIdCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        //public DeleteStudentByIdCommandResult Handle(DeleteStudentByIdCommand command)
        //{
        //    var deletedEntity = _studentContext.Students.Find(command.Id);
        //    _studentContext.Students.Remove(deletedEntity);
        //    _studentContext.SaveChanges();

        //    return new DeleteStudentByIdCommandResult
        //    {
        //        Id = deletedEntity.Id,
        //        Name = deletedEntity.Name,
        //        Age = deletedEntity.Age,
        //        Surname = deletedEntity.Surname
        //    };
        //}

        public async Task<DeleteStudentByIdCommandResult> Handle(DeleteStudentByIdCommand request, CancellationToken cancellationToken)
        {
            var deletedEntity = _studentContext.Students.Find(request.Id);
            _studentContext.Students.Remove(deletedEntity);
            await _studentContext.SaveChangesAsync();

            return new DeleteStudentByIdCommandResult
            {
                Id = deletedEntity.Id,
                Name = deletedEntity.Name,
                Age = deletedEntity.Age,
                Surname = deletedEntity.Surname
            };
        }
    }
}
