using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medical_Appointments.Entities;

[Table("Patients")]
public class Patient {

    [Key]
    public int PatientId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }
    [MaxLength(9)]
    public string Phone { get; set; } = string.Empty;

    public ICollection<Appointment> Appointments { get; set; } = [];

}