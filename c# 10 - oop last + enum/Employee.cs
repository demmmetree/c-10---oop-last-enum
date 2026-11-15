using System;

namespace c__10___oop_last___enum
{
    internal abstract class Employee
    {
        public string FullName { get; set; } = string.Empty;

        private decimal _sallary;
        public decimal Sallary
        {
            get { return _sallary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error: salary can not be negative");
                }
                else
                {
                    _sallary = value;
                }
            }
        }

        public Employee(string fullName, decimal sallary)
        {
            FullName = fullName;
            Sallary = sallary;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {FullName}, Salary: {Sallary}");
        }

        public abstract void PerformDuty();

        public abstract decimal CalculateBonus();
    }
}