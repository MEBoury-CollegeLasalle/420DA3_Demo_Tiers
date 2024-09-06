using _420DA3_Demo_Tiers.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Demo_Tiers.Presentation;
public partial class MainMenu : Form {
    private readonly TeacherService teacherService;
    private readonly StudentService studentService;
    private readonly CourseService courseService;
    private readonly ClassGroupService classGroupService;

    public MainMenu(
        TeacherService tService, 
        StudentService sService, 
        CourseService cService, 
        ClassGroupService cgService) {

        this.InitializeComponent();
        this.teacherService = tService;
        this.studentService = sService;
        this.courseService = cService;
        this.classGroupService = cgService;
    }
}
