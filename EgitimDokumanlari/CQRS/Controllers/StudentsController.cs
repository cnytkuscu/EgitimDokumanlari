using CQRS.CQRS.Commands;
using CQRS.CQRS.Handlers;
using CQRS.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }





        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var result = await _mediator.Send(new GetAllStudentQuery());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var result = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStudent(CreateStudentCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _mediator.Send(new DeleteStudentByIdCommand(id));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
