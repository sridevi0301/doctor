using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class PatientHandling
{
    private List<Patient> patients = new List<Patient>();
    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
        Console.WriteLine("Patient added successfully");
    }
    public Patient GetPatientById(int id)
    {
        return patients.FirstOrDefault(p => p.patientId == id);
    }
    public void DeletePatient(int id)
    {
        var patient = GetPatientById(id);
        if (patient != null)
        {
            patients.Remove(patient);
            Console.WriteLine("Patient Removed Successfully");
        }
        else
        {
            Console.WriteLine("Patient  not found");
        }
    }
    public void UpdatePatient(int id, string name, int age)
    {

        var patient = GetPatientById(id);
        if (patient != null)
        {
            patient.patientName = name;
            patient.patientAge = age;
            patient.patientId = id;    
            Console.WriteLine("Patient added successfully");
        }
        else
        {
            Console.WriteLine("Patient not found");
        }
    }
}
