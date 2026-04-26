using System.Numerics;

namespace HealthCareSystem_OOP
{
    internal class Program
    {
        // Data Storage 

        static List<Patient> patients = new List<Patient>();
        static bool exit = false;


        // system functions
        public static void seedData()
        {
            patients.Add(new Patient(
                "Ali Hassan", "P0", "Flu", false,
                "", "General", 2, 0,
                DateTime.Parse("2025-01-10"),
                DateTime.Parse("2025-01-15"),
                12, "A+"
            ));

            patients.Add(new Patient(
                "Sara Ahmed", "P1", "Fracture", true,
                "Noor", "Orthopedics", 4, 0,
                DateTime.Parse("2025-03-02"),
                DateTime.MinValue,
                8, "O-"
            ));

            patients.Add(new Patient(
                "Omar Khalid", "P2", "Diabetes", false,
                "", "Cardiology", 1, 0,
                DateTime.Parse("2024-12-20"),
                DateTime.Parse("2024-12-28"),
                5, "B+"
            ));
        }

        static public void displayMenu()
        {
            Console.WriteLine("Healthcare Management System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Register New Patient");
            Console.WriteLine("2. Admit Patient");
            Console.WriteLine("3. Discharge Patient");
            Console.WriteLine("4. Search Patient");
            Console.WriteLine("5. List All Admitted Patients");
            Console.WriteLine("6. Transfer Patient to Another Doctor");
            Console.WriteLine("7. View Most Visited Patients");
            Console.WriteLine("8. Search Patients by Department");
            Console.WriteLine("9. Billing Report");
            Console.WriteLine("10. Add Doctor");
            Console.WriteLine("11. Doctor Salary Report");
            Console.WriteLine("12. Exit");
        }

      
        public static void RegisterPatient()
        {
            Console.WriteLine("Enter patient name: ");
            string name = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the diagnose: ");
            string diagnose = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the blood type: ");
            string blood = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the department: ");
            string department = Console.ReadLine().ToLower();

            patients.Add(new Patient(name, diagnose, department, blood));


        }


        static void Main(string[] args)
        {
            seedData();

            while (exit == false)
            {
                displayMenu();

                Console.Write("Choose option: ");

                int choice = 0;

                try
                {

                    choice = int.Parse(Console.ReadLine() ?? string.Empty);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid input. Please choose a number from 1 to 10.");
                }

                switch (choice)
                {
                    case 1:
                        RegisterPatient();
                        
                        break;

                    case 2:




                        break;


                    case 3:



                        break;


                    case 4:
                        break;


                    case 5:
                        break;


                    case 6:
                        break;


                    case 7:
                        break;


                    case 8:

                        break;


                    case 9:
                        break;


                    case 10:
                        break;


                    case 11:
                        break;


                    case 12:
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please choose a number from 1 to 12.");
                        break;



                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();



            }
        }





        public class Patient
        {
            public string Name;
            public string ID;
            public string Diagnosis;
            public bool Admitted;
            public string assignedDoctor;
            public string Department;
            public int VisitCount;
            public double BillingAmount;
            public DateTime lastVisitDate;
            public DateTime lastDischargeDate;
            public int DaysInHospital;
            public string BloodType;

            public static int patientCount = 0;


            // create patient ( constructor ) one for seed data and one for user input

            public Patient(string name, string id, string diagnosis, bool admitted,
               string doctor, string department, int visitCount,
               double billingAmount, DateTime lastVisit,
               DateTime lastDischarge, int daysInHospital, string bloodType)
            {
                Name = name;
                ID = id;
                Diagnosis = diagnosis;
                Admitted = admitted;
                assignedDoctor = doctor;
                Department = department;
                VisitCount = visitCount;
                BillingAmount = billingAmount;
                lastVisitDate = lastVisit;
                lastDischargeDate = lastDischarge;
                DaysInHospital = daysInHospital;
                BloodType = bloodType;

                patientCount++;
            }



            public Patient(string name, string diagnosis, string department, string bloodType)
            {
                Name = name;
                Diagnosis = diagnosis;
                Department = department;
                BloodType = bloodType;

                Admitted = false;
                assignedDoctor = "";
                lastVisitDate = DateTime.MinValue;
                lastDischargeDate = DateTime.MinValue;

                VisitCount = 0;
                BillingAmount = 0.0;
                DaysInHospital = 0;

                ID = "P" + patientCount;

                patientCount++;

                Console.WriteLine("Patient registered successfully with Patient ID: " + ID);
            }

        }





    }
}
