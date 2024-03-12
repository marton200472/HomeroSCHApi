using System.ComponentModel.DataAnnotations;

namespace HomeroSCHApi;

public class Location
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}