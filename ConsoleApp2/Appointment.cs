using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public Patient Appointed { get; set; }
        public string Doctor { get; set; }
        DateTime Date { get; set; }

        public static List<Appointment> AppointmentList = new List<Appointment>();
        static int counter = 1;
        public static void AddAppointment()
        {
            Appointment appointment = new Appointment();
            appointment.Id = counter++;
            Console.WriteLine($"Patient Id: {int.Parse(Console.ReadLine())}");
            Console.Write("Reason: ");
            appointment.Reason = Console.ReadLine();
            AppointmentList.Add(appointment);
            Console.WriteLine("Appointment added successfully!");
        }
        public static void ViewAppointment()
        {
            Console.WriteLine("");
        }
        public static void UpdateAppointment()
        {
            Console.WriteLine("");
        }
    }
}
