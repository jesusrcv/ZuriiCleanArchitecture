namespace Zurii_Core.Models;

public class Area
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string? SubAreaOf { get; set; }
    public Organization Organization { get; set; }
}