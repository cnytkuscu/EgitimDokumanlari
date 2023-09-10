using CQRS.CQRS.Commands;
using CQRS.CQRS.Handlers;
using CQRS.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly DeleteStudentByIdCommandHandler _deleteStudentByIdCommandHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, DeleteStudentByIdCommandHandler deleteStudentByIdCommandHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _deleteStudentByIdCommandHandler = deleteStudentByIdCommandHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = _getAllStudentQueryHandler.Handle(new GetAllStudentQuery());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var result = this._getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var result = _deleteStudentByIdCommandHandler.Handle(new DeleteStudentByIdCommand(id));
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            var result = _updateStudentCommandHandler.Handle(command);
            return Ok(result);
        }
    }
}
