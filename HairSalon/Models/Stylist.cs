namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public Guid StylistId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}