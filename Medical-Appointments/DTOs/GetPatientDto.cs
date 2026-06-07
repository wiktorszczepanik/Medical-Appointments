using Medical_Appointments.Entities;

namespace Medical_Appointments.DTOs;

public class GetPatientDto {

    public int PatientId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; } = null!;
    public ICollection<AppointmentDto> Appointments { get; set; } = null!;
    
}

public class AppointmentDto {
    
    public int AppointmentId { get; set; }
    public DoctorDto Doctors { get; set; } = null!;
    public DateOnly AppointmentDate { get; set; }
    public string Status { get; set; }
    public ICollection<AppointmentMedicalDto> AppointmentServices { get; set; } = null!;
    
}

public class DoctorDto {
    
    public int DoctorId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Specialization { get; set; } = null!;
    public string Phone { get; set; } = null!;
    
}

public class AppointmentMedicalDto {
    
    public int AppointmentId { get; set; }
    public DateOnly PerformedAt { get; set; }
    
}