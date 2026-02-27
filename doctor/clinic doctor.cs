using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class ClinicService
{
    private List<Doctor> doctors = new List<Doctor>();
    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
        Console.WriteLine("Doctor added successfully");
    }
    public Doctor GetDoctorById(int id)
    {
        return doctors.Find(d => d.doctorID == id);
    }
    public void DeleteDoctor(int id)
    {
        var doctor = GetDoctorById((int)id);
        if (doctor != null)
        {
            doctors.Remove(doctor);
            Console.WriteLine("Doctor Removed Successfully");
        }
        else
        {
            Console.WriteLine("Doctor not found");
        }
    }
    public void UpdateDoctor(int id, string name,string type)
    {

        var doctor = GetDoctorById(id);
        if (doctor != null)
        {
            doctor.doctorName = name;
            doctor.doctorType = type;
            doctor.doctorID= id;
            Console.WriteLine("Doctor added successfully");
        }
        else
        {
            Console.WriteLine("Doctor not found");
        }
    }
}