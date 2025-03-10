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
        DateTime Date { get; set; }
        public static List<Patient> PatientList = Patient.PatientList;
        public static List<Appointment> AppointmentList = new List<Appointment>();
        static int counter = 1;
        public static void AddAppointment()
        {
            Appointment appointment = new Appointment();
            appointment.Id = counter++;
            Console.WriteLine($"Patient Id: {int.Parse(Console.ReadLine())}");
            Console.Write("Reason: ");
            appointment.Reason = Console.ReadLine();
            appointment.Date = DateTime.Now;
            AppointmentList.Add(appointment);
            Console.WriteLine("Appointment added successfully!");

        }
        public static void ViewAppointment()
        {
            if (AppointmentList.Count == 0)
            {
                Services.TextColor(color: ConsoleColor.Cyan, "No patient recorded!");
            }
            foreach (Appointment appointment in AppointmentList)
            {
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Patient patient = Services.GetById(id, PatientList);
                    if (patient != default)
                    {
                        Console.WriteLine($"Id:[{patient.Id}] Name:[{appointment.Date}]");
                    }
                    else { Console.WriteLine($"Patient with ID[{id}] not found!"); }
                }
                else { Services.TextColor(color: ConsoleColor.Red, "ID must be a number"); }
            }
        }
        public static void UpdateAppointment()
        {
            Console.WriteLine("");
        }
    }
}
