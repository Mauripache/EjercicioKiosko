using System;
using System.Text;

namespace Library
{
    /*
        No cumple SRP ya que si necesito cambiar cualquiera de las validaciones, o agregar mas
        datos necesarios para el appointment debo modificar esta clase.
        Movería los datos de name, id y phone number a una clase aparte ya que son todos datos
        de la persona que hace el appointment. Moveria appointmentPlace a una
        clase aparte ya que son datos del lugar del appointment. Movería el dato de doctorName 
        a una clase Doctor ya que son datos del doctor. Haría estos cambios
        ya que si no esta clase conocería datos que no están relacionados con un appointment de 
        primera mano y no cumpliría el SRP. De esta manera para cambiar cualquier validación 
        en los datos iría a sus clases correspondientes, para agregar datos lo mismo y en caso
        de necesitar nuevos detalles para un appointment puedo crear nuevas clases y requerirlas
        en una clase Appointment.
    */
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
