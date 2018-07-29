using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp_GovernmentAppWindows
{
    class Employee
    {
        private string employeeFirstName;
        private string employeeLastName;
        private double hoursWorked;
        private double hourlyRate;
        double grossPay;

        public Employee()
        {
            //empty, default constructor 
        }

        public Employee(string first, string last, double hrsWorked, double hrlyRate)
        {
            employeeFirstName = first;
            employeeFirstName = last;
            hoursWorked = hrsWorked;
            hourlyRate = hrlyRate;
        }

        public Employee(string first, string last)
        {
            employeeFirstName = first;
            employeeLastName = last;
        }

        public Employee(string first, string last, double hrsWorked)
        {
            employeeFirstName = first;
            employeeLastName = last;
            hoursWorked = hrsWorked;
        }

        //property used to access or change Employee First Name 
        public string EmployeeFirstName
        {
            set
            {
                employeeFirstName = value;
            }
            get
            {
                return employeeFirstName;
            }
        }

        //property used to access or change Employee Last Name 
        public string EmployeeLastName
        {
            set
            {
                employeeLastName = value;
            }
            get
            {
                return employeeLastName;
            }
        }

        //property used to access or change number of hours worked 
        public double HoursWorked
        {
            set
            {
                hoursWorked = value;
            }
            get
            {
                return hoursWorked;
            }
        }

        //property used to access or change houlry rate 
        public double HourlyRate
        {
            set
            {
                hourlyRate = value;
            }
            get
            {
                return hourlyRate;
            }
        }

        //calculate gross pay prior to deductions
        public double DetermineGross()
        {
            grossPay = hoursWorked * hourlyRate;
            return grossPay;
        }

        //using constant value for FICA tax currently, will change to array later
        public double DetermineFicaTax()
        {
            const double FICA = .0765;
            return DetermineGross() * FICA;
        }

        //calculate federal using constant for FED, * *
        public double DetermineFederalTax()
        {
            const double FED = .2;
            return DetermineGross() * FED;
        }

        //calculate State tax using const for STATE, * *
        public double DetermineStateTax()
        {
            const double STATE = .1;
            return DetermineGross() * STATE;
        }

        //calculate health insurance using HEALTH, * *
        public double DetermineHealthInsurance()
        {
            const double HEALTH = .07;
            return DetermineGross() * HEALTH;
        }

        //calculate net (gross - all deducations), * *
        public double DetermineNet()
        {
            return DetermineGross() - DetermineFicaTax() - DetermineFederalTax() - DetermineStateTax() - DetermineHealthInsurance();
        }

        public override string ToString()
        {
            return employeeFirstName + " " + employeeFirstName + "\nTake Home Pay: " + DetermineNet().ToString("C");
        }
    }
}
