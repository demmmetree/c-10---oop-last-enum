using System;

namespace c__10___oop_last___enum
{
    internal class Nurse : Employee, ICrazy
    {
        public Department Department { get; set; }
        public int ShiftsCompleted { get; private set; }

        public Nurse(string fullName, decimal sallary, Department department)
            : base(fullName, sallary)
        {
            Department = department;
        }

        public void CompleteShift()
        {
            ShiftsCompleted++;
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"{FullName} is helping a patient in {Department}.");
        }

        public override decimal CalculateBonus()
        {
            return ShiftsCompleted * 50;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Nurse, {Department}, shifts completed: {ShiftsCompleted}");
        }

        public void Jumping()
        {
            Console.WriteLine("Nurse is jumping!");
        }
    }

    public enum Department
    {
        Emergency,
        Surgery,
        Pediatrics,
        IntensiveCare
    }
}