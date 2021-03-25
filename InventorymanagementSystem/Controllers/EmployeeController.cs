using System.Linq;
using InventorymanagementSystme.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
[Authorize]
public class EmployeeController : Controller
{
    private EMSDbContext db;

    public EmployeeController(EMSDbContext _db)
    {
        db = _db;
    }

    public ActionResult Index()
    {
        var employees = db.Items.ToList();
        return View(employees);
    }
    public ActionResult Detail([FromQuery] int id)
    {
       var employee = db.Items.Find(id);
        return View(employee);
    }
    
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Add(Person person)
    {
        db.Items.Add(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var employee = db.Items.Find(id);
       return View(employee); 
    }

    [HttpPost]
    public ActionResult Edit(Person person)
    {
       db.Items.Attach(person);
       db.Items.Update(person);
       db.SaveChanges();
       return RedirectToAction(nameof(Index));
    }
     public ActionResult Delete(int id)
    {
        var employee = db.Items.Find(id);
       return View(employee); 
    }

    [HttpPost]
    public ActionResult Delete(Person person)
    {
         db.Items.Attach(person);
       db.Items.Remove(person);
       db.SaveChanges();
       return RedirectToAction(nameof(Index));
    }

}