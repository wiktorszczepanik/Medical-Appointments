using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Medical_Appointments.Entities;

[Table("Appointments")]
public class Appointment {

    [Key]
    public int AppointmentId { get; set; }
    
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly AppointmentDate { get; set; }
    [MaxLength(50)]
    public string Status { get; set; }

    [ForeignKey(nameof(PatientId))] 
    public Patient Patient { get; set; } = null!;

    [ForeignKey(nameof(DoctorId))] 
    public Doctor Doctor { get; set; } = null!;

    public ICollection<AppointmentMedical> AppointmentMedicals { get; set; } = [];
    
}