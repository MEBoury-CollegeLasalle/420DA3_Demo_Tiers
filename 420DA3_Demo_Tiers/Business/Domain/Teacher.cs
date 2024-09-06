namespace _420DA3_Demo_Tiers.Business.Domain;
public class Teacher {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeNumber { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    public Teacher(string firstName,
        string lastName,
        int employeeNumber) {

        this.FirstName = firstName;
        this.LastName = lastName;
        this.EmployeeNumber = employeeNumber;
    }

    public Teacher(int id,
        string firstName,
        string lastName,
        int employeeNumber,
        DateTime? dateCreated = null,
        DateTime? dateModified = null,
        DateTime? dateDeleted = null)
        : this(firstName, lastName, employeeNumber) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
    }
}
