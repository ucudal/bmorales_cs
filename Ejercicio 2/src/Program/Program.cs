using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("Steven Jhonson");
            Doctor doctor = new Doctor("Steven Jhonson");
            AppointmentService appointmentResult = new AppointmentService(patient.Name, "986782342", "5555-555-555", DateTime.Now, "Wall Street", doctor.Name);

            Console.WriteLine(appointmentResult.CreateAppointment());
        }
    }
}
