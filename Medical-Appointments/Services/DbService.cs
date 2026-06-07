using Medical_Appointments.Data;
using Medical_Appointments.DTOs;

namespace Medical_Appointments.Services;

public class DbService : IDbService {
    
    private readonly AppDbContext _context;
    
    public DbService(AppDbContext context) {
        _context = context;
    }
    
    public async Task<IEnumerable<GetPatientDto>> GetPatients() {
        var patients = await _context.Patients
            .Select(patient => new GetPatientDto() {
                PatientId = patient.PatientId,
                FirstName = patient.FirstName,
                DateOfBirth = patient.DateOfBirth,
                Phone = patient.Phone
            }).ToList();
        return patients;
    }
}