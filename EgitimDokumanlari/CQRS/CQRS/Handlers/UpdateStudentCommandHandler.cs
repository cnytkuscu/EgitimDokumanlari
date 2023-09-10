using CQRS.CQRS.Commands;
using CQRS.CQRS.Results;
using CQRS.Data;

namespace CQRS.CQRS.Handlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public UpdateStudentCommandResult Handle(UpdateStudentCommand command)
        {
            var student = _context.Students.Find(command.Id);
            if (student != null)
            {
                _context.Students.Update(new()
                {
                    Id = command.Id,
                    Age = command.Age,
                    Name = command.Name,
                    Surname = command.Surname
                });
            }

            return new()
            {
                Id = command.Id,
                Age = command.Age,
                Name = command.Name,
                Surname = command.Surname
            };
        }
    }
}
