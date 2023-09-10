namespace CQRS.CQRS.Results
{
    public class DeleteStudentByIdCommandResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
