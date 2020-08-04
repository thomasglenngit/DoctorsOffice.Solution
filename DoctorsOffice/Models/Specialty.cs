using System.Collections.Generic;
using System;


namespace DoctorsOffice.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.Doctors = new HashSet<DoctorSpecialty>();
    }
    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }
    public ICollection<DoctorSpecialty> Doctors { get; set; }
  }
}