using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeroSCHApi.Controllers;

public class MeasurementController : Controller
{
    private readonly HomeroschDbContext _dbContext;
    public MeasurementController(HomeroschDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("temp")]
    public async Task<IActionResult> Temp(float tempC, Guid id) {
        var device = await _dbContext.Devices.Include(x=>x.Location).FirstOrDefaultAsync(x=>x.Id == id);
        if (device is null)
        {
            return BadRequest("Nem regisztralt eszkoz!");
        }

        var measurement = new Models.Measurement {
            Device = device,
            Location = device.Location,
            Temperature = tempC,
            TimeStamp = DateTimeOffset.Now
        };
        
        _dbContext.Measurements.Add(measurement);
        await _dbContext.SaveChangesAsync();

        return Ok();
    }

    public record MeasurementData(float tempC, Guid id);

    [HttpPost("temp")]
    public async Task<IActionResult> Temp(MeasurementData data) {
        var device = await _dbContext.Devices.Include(x=>x.Location).FirstOrDefaultAsync(x=>x.Id == data.id);
        if (device is null)
        {
            return BadRequest("Nem regisztralt eszkoz!");
        }

        var measurement = new Models.Measurement {
            Device = device,
            Location = device.Location,
            Temperature = data.tempC,
            TimeStamp = DateTimeOffset.Now
        };
        
        _dbContext.Measurements.Add(measurement);
        await _dbContext.SaveChangesAsync();

        return Ok();
    }


}