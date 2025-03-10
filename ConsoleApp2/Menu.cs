using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Menu
    {
        public static void Run()
        {
            MainMenu();
        }
        public  static void MainMenu() 
        {
            Console.WriteLine("====DOCTOR MANAGEMENT SYSYEM====\n");
            Console.WriteLine("1.Patients\n2.Appointments\n3.Exit");
            int input;
            if(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid Input");
                MainMenu();
            }
            switch (input)
            {
                case 1: PatientMenu(); break;
                case 2: AppointmentMenu(); break;
                case 3: Console.WriteLine("Successful Termination"); Environment.Exit(0); break;
            }
        }
        public static void PatientMenu()
        {
            Console.WriteLine("1.Add Patient\n2.View Patient\n3.View Patient Details\n4.Update Patient\n5.Delete Patient\n6.Back");
            string input = Console.ReadLine();
            bool isValid = true;
            while (isValid == true) 
            {
                switch (input)
                {
                
                    case "1": Patient.AddPatient(); break;
                    case "2": Patient.ViewPatient(); break;
                    case "3": Patient.ViewPatientDetails(); break;
                    case "4": Patient.UpdatePatient(); break;
                    case "5": Patient.DeletePatient(); break;
                    case "6": MainMenu();break;
                    default: Console.WriteLine("You must choose a valid option"); break;
                }
                PatientMenu();
            }
        }
        public static void AppointmentMenu()
        {
             Console.WriteLine("1.Add Appointment\n2.View Appointment\n3.Update Appointment\n4.Delete Appointment\n5.Back");
             string input = Console.ReadLine();
            switch (input)
            {
                case "1": Appointment.AddAppointment(); break;
                case "2": Appointment.ViewAppointment(); break;
                case "3": Appointment.UpdateAppointment();break;
            }
        }
    }
}
