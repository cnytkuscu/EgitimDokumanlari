using CQRS.CQRS.Commands;
using CQRS.CQRS.Results;
using CQRS.Data;

namespace CQRS.CQRS.Handlers
{
    public class DeleteStudentByIdCommandHandler
    {

        private readonly StudentContext _studentContext;

        public DeleteStudentByIdCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public DeleteStudentByIdCommandResult Handle(DeleteStudentByIdCommand command)
        {
            var deletedEntity = _studentContext.Students.Find(command.Id);
            _studentContext.Students.Remove(deletedEntity);
            _studentContext.SaveChanges();

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
