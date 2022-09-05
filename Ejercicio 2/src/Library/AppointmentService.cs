using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /// EL nombre del paciente deberia de estar en un constructor de otra clase.
        /// Lo mismo para doctor
        /// Appitment no tiene constructor
        /// 
        public string Name { get ; set ; }
        public string Id { get ; set ; }
        public string PhoneNumber { get ; set ; }
        public DateTime Date { get ; set ; }
        public string AppointmentPlace { get ; set ; }
        public string DoctorName { get ; set ; }

        public AppointmentService(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Date =  date;
            this.AppointmentPlace = appointmentPlace;
            this.DoctorName = doctorName;
            Console.WriteLine($"Name: {name}, id: {id}, phone: {phoneNumber}, date: {date}, place: {appointmentPlace}, doctor: {doctorName}");
        }

        public string CreateAppointment()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(AppointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
