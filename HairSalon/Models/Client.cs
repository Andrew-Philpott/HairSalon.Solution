namespace Salon.Models
{
  public class Client
  {
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public Guid StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}