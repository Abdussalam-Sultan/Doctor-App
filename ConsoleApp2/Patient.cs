using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int age { get; set; }
        int Age {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be between  and 120");
                }
                age = value;
            }
        }
        Gender Gender { get; set; }
        string Contact { get; set; }

        public static List<Patient> PatientList = new List<Patient>();
        static int counter = 1;

        public static void AddPatient()
        {
            Patient patient = new Patient();
            patient.Id = counter++;
            Console.WriteLine($"* shows which information is necessary\nId: {patient.Id}");
            Console.Write("*Name: ");
            patient.Name = Console.ReadLine();
            Console.Write("*Age: ");
            int age;
            if(int.TryParse(Console.ReadLine(), out age))
            {
                patient.Age = age;
                Console.Write("Gender[M]/[F]: ");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (char.ToUpper(key.KeyChar))
                {
                    case 'M': patient.Gender = Gender.Male; break;
                    case 'F': patient.Gender = Gender.Female; break;
                    default: patient.Gender = Gender.Unspecified; break;
                }
                PatientList.Add(patient);
                Console.WriteLine("\nPatient added successfully!");
            }
            else {Services.TextColor(ConsoleColor.Red, "Age must be a number");}

        }
        public static void ViewPatient()
        {
            if( PatientList.Count == 0 )
            {
                Console.WriteLine("No patient recorded!");
            }
            foreach (Patient patient in PatientList) {
                Console.WriteLine($"Id:[{patient.Id}] Name:[{patient.Name}] Age:[{patient.Age}]");
            }
        }
        public static void ViewPatientDetails()
        {
            Console.Write("Id: ");
            if(int.TryParse(Console.ReadLine(), out int id))
            {
                Patient patient = Services.GetById(id, PatientList);
                if (patient != default)
                {
                    Console.WriteLine($"Id:[{patient.Id}] Name:[{patient.Name}] Age:[{patient.Age}] Gender:[{patient.Gender}]");
                }
                else { Console.WriteLine($"Patient with ID[{id}] not found!"); }
            }else { Console.WriteLine("ID must be a number"); };
        }
        public static void UpdatePatient()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Patient patient = Services.GetById(id, PatientList);
            if (patient == default)
            {
               Console.WriteLine("Patient not found");
            }
            Console.Write($"Old Name: {patient.Name}\nNew name: ");
            patient.Name = Console.ReadLine();
            Console.WriteLine($"Patient {patient.Id} name updated to [{patient.Name}]");
        }
        public static void DeletePatient()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Patient patient = Services.GetById(id, PatientList);
            Console.WriteLine($"Deleted patient [{patient.Id}]");
            PatientList.Remove(patient);
            
        }
    }
}
