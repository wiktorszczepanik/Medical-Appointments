using Medical_Appointments.Exceptions;
using Medical_Appointments.Services;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Appointments.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase {
    
    private readonly IDbService _dbService;

    public PatientsController(IDbService dbService) {
        _dbService = dbService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatients() {
        var patients = await _dbService.GetPatients();
        return Ok(patients);
    }
    
}