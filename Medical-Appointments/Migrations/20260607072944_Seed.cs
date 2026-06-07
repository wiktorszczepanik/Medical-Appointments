using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Medical_Appointments.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "FirstName", "LastName", "Phone", "Specialization" },
                values: new object[,]
                {
                    { 1, "Maciej", "TezNowak", "423456789", "Kardiologia" },
                    { 2, "Adam", "Nowak", "523456789", "TezNic" },
                    { 3, "Anna", "Kowalska", "623456789", "Nic" }
                });

            migrationBuilder.InsertData(
                table: "Medical_Services",
                columns: new[] { "ServiceId", "Description", "DurationInMinutes", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "bla bla bla", 90, "Zabieg1", 100m },
                    { 2, "bla bla bla", 120, "Zabieg3", 200m },
                    { 3, "bla bla bla", 30, "Zabieg3", 300m }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "DateOfBirth", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", "123456789" },
                    { 2, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Kowalska", "223456789" },
                    { 3, new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Nowak", "323456789" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2026, 7, 1), 1, 1, "Pending" },
                    { 2, new DateOnly(2026, 8, 1), 2, 2, "Pending" },
                    { 3, new DateOnly(2026, 9, 1), 3, 3, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Appointment_Services",
                columns: new[] { "AppointmentId", "ServiceId", "PerformedAt", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2026, 7, 1), 1 },
                    { 2, 2, new DateOnly(2026, 8, 1), 1 },
                    { 3, 3, new DateOnly(2026, 9, 1), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment_Services",
                keyColumns: new[] { "AppointmentId", "ServiceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Appointment_Services",
                keyColumns: new[] { "AppointmentId", "ServiceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Appointment_Services",
                keyColumns: new[] { "AppointmentId", "ServiceId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medical_Services",
                keyColumn: "ServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medical_Services",
                keyColumn: "ServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medical_Services",
                keyColumn: "ServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3);
        }
    }
}
