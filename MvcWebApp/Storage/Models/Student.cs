namespace MvcWebApp.Storage.Models;

public class Student
{
    public int Id { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public int IndexNumber { get; set; }

}
