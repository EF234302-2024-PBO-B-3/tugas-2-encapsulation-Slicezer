using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _firstName = value;
                else
                    _firstName = "Unknown";
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _lastName = value;
                else
                    _lastName = "Unknown";
            }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0)
                    _monthlySalary = value;
            }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            if (monthlySalary > 0)
                _monthlySalary = monthlySalary;
            else
                _monthlySalary = 0.0;
        }

        public void RaiseSalary(int raisePercentage)
        {
            // Pastikan raisePercentage tidak negatif dan tidak lebih dari 20%
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += _monthlySalary * raisePercentage / 100;
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
