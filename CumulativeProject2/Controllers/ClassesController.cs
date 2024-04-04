using System.Web.Mvc;

namespace CumulativeProject2.Controllers;

public class ClassesController : Controller
{
    // GET: Classes
    public ActionResult Index()
    {
        return View();
    }

    //GET : /Classes/List
    public ActionResult List()
    {
        var controller = new ClassesDataController();
        var classes = controller.ListClasses();
        return View(classes);
    }

    //GET : /Classes/Show/{id}
    public ActionResult Show(int id)
    {
        var controller = new ClassesDataController();
        var newClasses = controller.FindClasses(id);


        return View(newClasses);
    }
}