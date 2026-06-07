using Medical_Appointments.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medical_Appointments.Data;

public class AppDbContext : DbContext {
    
    protected AppDbContext() {}

    public AppDbContext(DbContextOptions options) : base(options) {}
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<AppointmentMedical> AppointmentMedicals { get; set; }
    public DbSet<Medical> Medicals { get; set; }
    
}