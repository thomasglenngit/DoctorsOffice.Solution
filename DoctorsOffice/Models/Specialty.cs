using System;
using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.Doctors = new HashSet<DoctorSpecialty>();
    }
    public int SpecialtyId { get; set; }
    public string Specialty { get; set; }
    public ICollection<DoctorSpecialty> Specialties { get; }
  }
}