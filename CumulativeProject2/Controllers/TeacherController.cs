using System.Web.Mvc;

namespace CumulativeProject2.Controllers;

public class TeacherController : Controller
{
    // GET: Teacher
    public ActionResult Index()
    {
        return View();
    }

    //GET : /Teacher/List
    public ActionResult List()
    {
        var controller = new TeacherDataController();
        var teacher = controller.ListTeachers();
        return View(teacher);
    }

    //GET : /Teacher/Show/{id}
    public ActionResult Show(int id)
    {
        var controller = new TeacherDataController();
        var newTeacher = controller.FindTeacher(id);


        return View(newTeacher);
    }
    
    
    //GET : /Teacher/New
    public ActionResult New()
    {
        return View();
    }
}