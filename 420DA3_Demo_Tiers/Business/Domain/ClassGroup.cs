using _420DA3_Demo_Tiers.Business.Domain.Enums;

namespace _420DA3_Demo_Tiers.Business.Domain;
public class ClassGroup {
    public int Id { get; set; }
    public int GroupNumber { get; set; }
    public SemestersEnum Semester { get; set; }
    public int SemesterYear { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }

    public Course Course { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
}
