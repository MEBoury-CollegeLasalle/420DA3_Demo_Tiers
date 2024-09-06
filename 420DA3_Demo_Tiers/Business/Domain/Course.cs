namespace _420DA3_Demo_Tiers.Business.Domain;

public class Course {
    public int Id { get; set; }
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public int TheoryWeight { get; set; }
    public int PracticeWeight { get; set; }
    public int HomeworkWeight { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    public Course(string courseCode, 
        string courseName, 
        int theoryWeight, 
        int practiceWeight, 
        int homeworkWeight) { 

        this.CourseCode = courseCode;
        this.CourseName = courseName;
        this.TheoryWeight = theoryWeight;
        this.PracticeWeight = practiceWeight;
        this.HomeworkWeight = homeworkWeight;
    }

    public Course(int id, 
        string courseCode,
        string courseName,
        int theoryWeight,
        int practiceWeight,
        int homeworkWeight,
        DateTime? dateCreated = null,
        DateTime? dateModified = null,
        DateTime? dateDeleted = null) 
        : this(courseCode, courseName, theoryWeight, practiceWeight, homeworkWeight) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
    }

}
