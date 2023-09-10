namespace CQRS.CQRS.Commands
{
    public class DeleteStudentByIdCommand
    {
        public int Id { get; set; }

        public DeleteStudentByIdCommand(int id)
        {
            Id = id;
        }
    }
}
