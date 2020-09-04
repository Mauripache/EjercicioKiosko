using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentPlace place = new AppointmentPlace("Hospital");
            Doctor doctor = new Doctor("Dr.Watson");
            Patient patient = new Patient("Patient Patientson", "1234567", "911");

            Appointment appointment = Appointment.CreateAppointment(doctor, patient, place);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(appointment.AppointmentPlace.Name);
            Console.WriteLine(appointment.Doctor.Name);
            Console.WriteLine(appointment.Patient.Name);
        }
    }
}
