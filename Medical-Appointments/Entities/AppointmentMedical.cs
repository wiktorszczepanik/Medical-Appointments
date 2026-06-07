using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Medical_Appointments.Entities;

[Table("Appointment_Services")]
[PrimaryKey(nameof(AppointmentId), nameof(ServiceId))]
public class AppointmentMedical {

    public int AppointmentId { get; set; }
    public int ServiceId { get; set; }
    public int Quantity { get; set; }
    public DateOnly PerformedAt { get; set; }
    
    [ForeignKey(nameof(AppointmentId))] 
    public Appointment Appointment { get; set; } = null!;

    [ForeignKey(nameof(ServiceId))] 
    public Medical Medical { get; set; } = null!;
    
}