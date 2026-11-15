using System;

namespace c__10___oop_last___enum
{
    internal class Doctor : Employee, ICrazy
    {
        public Specialization Specialization { get; set; }
        public int PatientsExamined { get;  set; }

        public Doctor(string fullName, decimal sallary, Specialization specialization)
            : base(fullName, sallary)
        {
            Specialization = specialization;
        }

        public override void PerformDuty()
        {
            PatientsExamined++;
            Console.WriteLine($"{FullName} is examining a patient as a {Specialization}.");
        }

        public override decimal CalculateBonus()
        {
            return PatientsExamined * 20;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Doctor, {Specialization}, patients examined: {PatientsExamined}");
        }

        public void Jumping()
        {
            Console.WriteLine("I am jumping!");
        }
    }

    public enum Specialization
    {
        Cardiologist,
        Dentist,
        Neurologist,
        Pediatrician,
        Surgeon
    }
}