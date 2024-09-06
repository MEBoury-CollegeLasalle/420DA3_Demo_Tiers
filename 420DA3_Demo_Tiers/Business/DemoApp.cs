using _420DA3_Demo_Tiers.Business.Services;
using _420DA3_Demo_Tiers.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Demo_Tiers.Business;
internal class DemoApp {
    public TeacherService TeacherService { get; private set; }
    public StudentService StudentService { get; private set; }
    public CourseService CourseService { get; private set; }
    public ClassGroupService ClassGroupService { get; private set; }

    private readonly MainMenu mainMenu;


    private static DemoApp? instance;

    private DemoApp() {
        ApplicationConfiguration.Initialize();
        this.TeacherService = new TeacherService();
        this.StudentService = new StudentService();
        this.CourseService = new CourseService();
        this.ClassGroupService = new ClassGroupService();
        this.mainMenu = new MainMenu(this.TeacherService, this.StudentService, this.CourseService, this.ClassGroupService);

    }

    public static DemoApp GetInstance() {
        instance ??= new DemoApp();
        return instance;
    }

    public void Run() {
        Application.Run(this.mainMenu);
    }

    public static void Terminate() {
        Application.Exit();
    }
}
