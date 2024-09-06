namespace _420DA3_Demo_Tiers.Business.Domain;
public class Student {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int StudentNumber { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }


    public Student(string firstName,
        string lastName,
        int studentNumber) {

        this.FirstName = firstName;
        this.LastName = lastName;
        this.StudentNumber = studentNumber;
    }

    public Student(int id,
        string firstName,
        string lastName,
        int studentNumber,
        DateTime? dateCreated = null,
        DateTime? dateModified = null,
        DateTime? dateDeleted = null)
        : this(firstName, lastName, studentNumber) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
    }

}
