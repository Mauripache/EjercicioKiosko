using System;

namespace Library
{
    public class Appointment
    {
        public Doctor Doctor{get;set;}
        public Patient Patient{get;set;}
        public AppointmentPlace AppointmentPlace{get;set;}

        public Appointment(Doctor doctor, Patient patient, AppointmentPlace appointmentPlace)
        {
                this.Doctor = doctor;
                this.Patient = patient;
                this.AppointmentPlace = appointmentPlace;
        }

        public static Appointment? CreateAppointment(Doctor doctor, Patient patient, AppointmentPlace appointmentPlace)
        {
            Appointment newAppointment = new Appointment(doctor, patient, appointmentPlace);
            if (newAppointment.Doctor.IsValid() && newAppointment.Patient.IsValid() && newAppointment.AppointmentPlace.IsValid())
            {
                return newAppointment;
            }
            else
            {
                return null;
            }
        }
    }
}
