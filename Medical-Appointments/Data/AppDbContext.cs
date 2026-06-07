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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Patient>().HasData(new List<Patient>() {
            new() {PatientId = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(2000, 1, 1), Phone = "123456789"},
            new() {PatientId = 2, FirstName = "Alice", LastName = "Kowalska", DateOfBirth = new DateTime(2000, 2, 1), Phone = "223456789"},
            new() {PatientId = 3, FirstName = "Bob", LastName = "Nowak", DateOfBirth = new DateTime(2000, 3, 1), Phone = "323456789"}
        });
        
        
        modelBuilder.Entity<Appointment>().HasData(new List<Appointment>() {
            new() {AppointmentId = 1, PatientId = 1, DoctorId = 1, AppointmentDate = new DateOnly(2026, 7, 1), Status = "Pending"},
            new() {AppointmentId = 2, PatientId = 2, DoctorId = 2, AppointmentDate = new DateOnly(2026, 8, 1), Status = "Pending"},
            new() {AppointmentId = 3, PatientId = 3, DoctorId = 3, AppointmentDate = new DateOnly(2026, 9, 1), Status = "Pending"},
        });
        
        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>() {
            new() {DoctorId = 1, FirstName = "Maciej", LastName = "TezNowak", Specialization = "Kardiologia", Phone = "423456789"},
            new() {DoctorId = 2, FirstName = "Adam", LastName = "Nowak", Specialization = "TezNic", Phone = "523456789"},
            new() {DoctorId = 3, FirstName = "Anna", LastName = "Kowalska", Specialization = "Nic", Phone = "623456789"}
        });
        
        modelBuilder.Entity<AppointmentMedical>().HasData(new List<AppointmentMedical>() {
            new() {AppointmentId = 1, ServiceId = 1, Quantity = 1, PerformedAt = new DateOnly(2026, 7, 1)},
            new() {AppointmentId = 2, ServiceId = 2, Quantity = 1, PerformedAt = new DateOnly(2026, 8, 1)},
            new() {AppointmentId = 3, ServiceId = 3, Quantity = 1, PerformedAt = new DateOnly(2026, 9, 1)}
        });
        
        modelBuilder.Entity<Medical>().HasData(new List<Medical>() {
            new() {ServiceId = 1, Name = "Zabieg1", Description = "bla bla bla", Price = 100, DurationInMinutes = 90},
            new() {ServiceId = 2, Name = "Zabieg3", Description = "bla bla bla", Price = 200, DurationInMinutes = 120},
            new() {ServiceId = 3, Name = "Zabieg3", Description = "bla bla bla", Price = 300, DurationInMinutes = 30},
        });
        
    }
    
}