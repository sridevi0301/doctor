using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class AppointmentHandling
{
    private List<Appointment> appointments = new List<Appointment>();
    public void AddAppointment(Appointment appointment)
    {
        appointments.Add(appointment);
        Console.WriteLine("Appointment added successfully");
    }
    public Appointment GetAppointmentById(int id)
    {
        return appointments.FirstOrDefault(a => a.appointmentID == id);
    }
    public void DeleteAppointment(int id)
    {
        var appointment = GetAppointmentById((int )id);
        if (appointment != null)
        {
            appointments.Remove(appointment);
            Console.WriteLine("Appointment Removed Successfully");
        }
        else
        {
            Console.WriteLine("Appointment  not found");
        }
    }
    public void UpdateAppointment(int appointmentId, int doctorId, int patientId)
    {

        var appointment = GetAppointmentById(appointmentId);
        if (appointment != null)
        {
            appointment.doctorID = doctorId;
            appointment.patientID = patientId;
            Console.WriteLine("Appointment added successfully");
        }
        else
        {
            Console.WriteLine("Appointment not found");
        }
    }
}
