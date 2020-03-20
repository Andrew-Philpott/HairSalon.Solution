using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public Guid StylistId { get; set; }
    public string Name { get; set; }
    // public TimeSpan ShiftStart { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
    // public virtual ICollection<Appointment> Appointments { get; set; }
  }
}