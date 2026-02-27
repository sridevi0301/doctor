public class Program
{
    public static void Main(string[] args)
    {
        ClinicService clinic = new ClinicService();
        PatientHandling pat = new PatientHandling();
        AppointmentHandling apo = new AppointmentHandling();
        InvoiceHandling invo = new InvoiceHandling();
        while (!exit)
        {
            Console.WriteLine("\n---select details----");
            Console.WriteLine("1.Add Doctor: ");
            Console.WriteLine("2.Get By Doctorid: ");
            Console.WriteLine("3.Update doctor: ");
            Console.WriteLine("4.Delete doctor: ");
            Console.WriteLine("5.Add Patient: ");
            Console.WriteLine("6.Get by patientid: ");
            Console.WriteLine("7.Update patient: ");
            Console.WriteLine("8.Delete Patient: ");
            Console.WriteLine("9.Add appointment: ");
            Console.WriteLine("10.Get appointment by id: ");
            Console.WriteLine("11.Update appointment: ");
            Console.WriteLine("12.Delete appointment: ");
            Console.WriteLine("13.Add invoice: ");
            Console.WriteLine("14.Get invoice by id: ");
            Console.WriteLine("15.Delete invoice: ");
            Console.WriteLine("16.Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter type: ");
                    string type = Console.ReadLine();
                    Doctor newDoctor = new Doctor();
                    clinic.AddDoctor(newDoctor);
                    break;
                case 2:
                    Console.Write("Enter doctor id: ");
                    int sid = int.Parse(Console.ReadLine());
                    var doctor = clinic.GetDoctorById(sid);
                    if (doctor != null)
                    {
                        Console.WriteLine($"{doctor.doctorID} - {doctor.doctorName} - {doctor.doctorType}");
                    }
                    else
                    {
                        Console.WriteLine("Doctor not found");
                    }
                    break;
                case 3:
                    Console.Write("Enter id to update: ");
                    int updateid = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string doctorname = Console.ReadLine();
                    Console.Write("Enter the type: ");
                    string doctortype = Console.ReadLine();
                    clinic.UpdateDoctor(updateid, doctorname, doctortype);
                    break;
                case 4:
                    Console.Write("Enter Doctor Id to Delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    clinic.DeleteDoctor(deleteId);
                    break;
                case 5:

                    Console.Write("Enter Patient Name: ");
                    string patientName = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Patient Id: ");
                    int patientId = int.Parse(Console.ReadLine());
                    Patient patient1 = new Patient();
                    patient1.patientId = patientId;
                    pat.AddPatient(patient1);
                    break;
                case 6:
                    Console.Write("Enter Patient Id: ");
                    int pid = int.Parse(Console.ReadLine());
                    var patienthandling = pat.GetPatientById(pid);
                    if (patienthandling != null)
                        Console.WriteLine($"{patient.PatientId} - {patient.Name} - {patient.Age}");
                    else
                        Console.WriteLine("Patient not found");
                    break;

                case 7:
                    Console.Write("Enter Patient Id to Update: ");
                    int upPid = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Name: ");
                    string newPatientName = Console.ReadLine();
                    Console.Write("Enter New Age: ");
                    int newAge = int.Parse(Console.ReadLine());
                    pat.UpdatePatient(upPid, newPatientName, newAge);
                    break;

                case 8:
                    Console.Write("Enter Patient Id to Delete: ");
                    int delPid = int.Parse(Console.ReadLine());
                    pat.DeletePatient(delPid);
                    break;

                case 9:
                    Console.Write("Enter Appointment Id: ");
                    int appId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Doctor Id: ");
                    int dId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Patient Id: ");
                    int pId = int.Parse(Console.ReadLine());
                    apo.AddAppointment(appId, dId, pId);
                    break;

                case 10:
                    Console.Write("Enter Appointment Id: ");
                    int getAppId = int.Parse(Console.ReadLine());
                    var appointment = apo.GetAppointmentById(getAppId);
                    if (appointment != null)
                        Console.WriteLine($"{appointment.AppointmentId} - {appointment.Date}");
                    else
                        Console.WriteLine("Appointment not found");
                    break;

                case 11:
                    Console.Write("Enter Appointment Id to Update: ");
                    int upAppId = int.Parse(Console.ReadLine());
                    break;

                case 12:
                    Console.Write("Enter Appointment Id to Delete: ");
                    int delAppId = int.Parse(Console.ReadLine());
                    apo.DeleteAppointment(delAppId);
                    break;

                case 13:
                    Console.Write("Enter Invoice Id: ");
                    int invoiceId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    invo.AddInvoice(invoiceId, amount);
                    break;

                case 14:
                    Console.Write("Enter Invoice Id: ");
                    int getInvId = int.Parse(Console.ReadLine());
                    var invoice = invo.GetInvoiceById(getInvId);
                    if (invoice != null)
                        Console.WriteLine($"{invoice.InvoiceId} - {invoice.Amount}");
                    else
                        Console.WriteLine("Invoice not found");
                    break;

                case 15:
                    Console.Write("Enter Invoice Id to Delete: ");
                    int delInvId = int.Parse(Console.ReadLine());
                    invo.DeleteInvoice(delInvId);
                    break;

                case 16:
                    exit = true;
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

}