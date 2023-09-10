using CQRS.CQRS.Commands;
using CQRS.CQRS.Results;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS.CQRS.Handlers
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, UpdateStudentCommandResult>
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<UpdateStudentCommandResult> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _context.Students.Find(request.Id);
            if (student != null)
            {
                _context.Students.Update(new()
                {
                    Id = request.Id,
                    Age = request.Age,
                    Name = request.Name,
                    Surname = request.Surname
                });

                _context.SaveChangesAsync();
            }

            return new()
            {
                Id = request.Id,
                Age = request.Age,
                Name = request.Name,
                Surname = request.Surname
            };
        }

    }

      
    }
 