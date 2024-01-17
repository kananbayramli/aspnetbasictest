using basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic.Controllers;

public class CourseController : Controller {

public IActionResult Index(){

    var kurs = new Course();
    kurs.Title = "Kurs";
    kurs.Description = "Cok Guzel Kurs";
    kurs.Image = "flutter(1).png";
    kurs.Id = 3;
    return View(kurs);
}

public IActionResult Details(int id){

    var kurs = Repository.GetById(id);

    return View(kurs);
}

public IActionResult Listler(){
    return View(Repository.Courses);
}

}