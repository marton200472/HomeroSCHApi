using System.ComponentModel.DataAnnotations;

namespace HomeroSCHApi.Models;

public class Measurement
{
    [Key]
    public int Id { get; set; }
    public float Temperature { get; set; }
    public DateTimeOffset TimeStamp { get; set; }

    public Location Location { get; set; }

    public Device Device {get;set;} = null!;
}