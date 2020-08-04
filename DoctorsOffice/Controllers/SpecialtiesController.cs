using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorsOffice.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly DoctorsOfficeContext _db;

    public SpecialtiesController(DoctorsOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Doctors = new List<Doctor>(_db.Doctors.ToList());
      return View(_db.Specialties.OrderBy(Doctor => Doctor.SpecialtyName).ToList());
    }
  
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
      _db.Specialties.Add(specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
      {
        var thisSpecialty = _db.Specialties.FirstOrDefault(specialties => specialties.SpecialtyId == id);
        return View(thisSpecialty);
      }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSpecialty = _db.Specialties.FirstOrDefault(specialties => specialties.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisSpecialty = _db.Specialties.Include(specialty => specialty.Doctors).FirstOrDefault(specialties => specialties.SpecialtyId == id);
      return View(thisSpecialty);
    }
  }
}