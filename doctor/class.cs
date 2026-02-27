using System;
using static System.Reflection.Metadata.BlobBuilder;
public class Doctor
{
    public int doctorID { get; set; }
    public string doctorName { get; set; }
    public string doctorType { get; set; }
}
public class Patient
{
    public string patientName { get; set; }
    public int  patientAge { get; set; }
    public int patientId { get; set; }
}
public class Appointment
{
    public int appointmentID { get; set; }
    public int doctorID { get; set; }
    public int patientID { get; set; }
}
public class Invoice
{
    public  int Amount { get; set; }
    public  int InvoiceID { get; set; }
}