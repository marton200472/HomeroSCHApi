using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeroSCHApi;

public class Device
{
    [Key]
    public Guid Id { get; set; }
    public Location Location { get; set; } = null!;
}