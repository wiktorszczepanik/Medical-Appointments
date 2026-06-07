using Medical_Appointments.DTOs;

namespace Medical_Appointments.Services;

public interface IDbService {
    Task<IEnumerable<GetPatientDto>> GetPatients();
    
}
