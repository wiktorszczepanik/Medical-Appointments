using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medical_Appointments.Entities;

[Table("Medical_Services")]
public class Medical {

    [Key]
    public int ServiceId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }
    public int DurationInMinutes { get; set; }
    
    public ICollection<AppointmentMedical> AppointmentMedicals { get; set; } = [];
    
}