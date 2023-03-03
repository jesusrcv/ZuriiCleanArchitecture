namespace Zurii_Core.Models;

public class Organization
{
    public string Id { get; set; }
    public string Name { get; set; }
    public ICollection<Area> Areas { get; set; }
}