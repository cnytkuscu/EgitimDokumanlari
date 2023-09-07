namespace Interface_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PersonManagement pm = new PersonManagement();

            pm.AddPerson(new Student { Id = 1, FirstName = "Cuneyt", LastName = "Kuscu", Department = "Software Engineering" });

            Console.ReadLine();

        }
    }

    // Buna soyut nesne denir. Bir anlamı yok ancak tanımları var.
    public interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //somut nesnedir. Anlamlı yapılardır.
    public class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    public class PersonManagement
    {
        public void AddPerson(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}