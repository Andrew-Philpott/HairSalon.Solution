using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public enum TimeSlot
  {
    First = 1,
    Second = 2,
    Third = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7

  }
  public class Appointment
  {
    public Guid AppointmentId { get; set; }
    public TimeSlot TimeSlot { get; set; }
    public Guid StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public Guid ClientId { get; set; }
    public virtual Client Client { get; set; }
  }
}