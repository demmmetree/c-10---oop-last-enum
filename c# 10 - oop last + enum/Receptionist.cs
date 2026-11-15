using System;

namespace c__10___oop_last___enum
{
    internal class Receptionist : Employee
    {
        public int RegisteredPatients { get; private set; }

        public Receptionist(string fullName, decimal sallary)
            : base(fullName, sallary)
        {
        }

        public override void PerformDuty()
        {
            RegisteredPatients++;
            Console.WriteLine($"{FullName} is registering patients.");
        }

        public override decimal CalculateBonus()
        {
            return RegisteredPatients * 5;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Receptionist, registered patients: {RegisteredPatients}");
        }
    }
}