using System;
using System.Collections.Generic;

namespace c__10___oop_last___enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor("Giorgi Bakradze", 3000, Specialization.Cardiologist);
            var nurse = new Nurse("Nino Kapanadze", 1500, Department.Surgery);
            var receptionist = new Receptionist("Mariam Lomidze", 1200);

            List<Employee> employees = new List<Employee> { doctor, nurse, receptionist };

            doctor.PerformDuty();
            doctor.PerformDuty();
            nurse.PerformDuty();
            nurse.CompleteShift();
            receptionist.PerformDuty();

            foreach (Employee e in employees)
            {
                e.ShowInfo();
                Console.WriteLine($"Bonus: {e.CalculateBonus()}");
                Console.WriteLine("----------");
            }

            doctor.Sallary = -500; 
        }
    }
}