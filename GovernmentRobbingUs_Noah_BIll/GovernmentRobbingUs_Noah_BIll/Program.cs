//Noah Jager
//Wil Holmes
//Pay Deduction App based on State
//"GovtGetsUs"
//July 22 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GovernmentRobbingUs_Noah_BIll
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHeadingAndInstructions();
           
            //NOTE: These are just trial values right now

            string[] stateNameArr = { "RI" };
            double[] ficaTaxArr = { .0765 };
            double[] fedTaxArr = { .2 };
            double[] stateTaxArr = { .1 };
            double[] healthInsurArr = { .07 };

           

            //pass arrays to class 

            DeductionsCalculator aDeductionsCalculator = new DeductionsCalculator
            {
                StateName = stateNameArr,
                FicaTax = ficaTaxArr,
                FedTax = fedTaxArr,
                StateTax = stateTaxArr,
                HealthInsurance = healthInsurArr
            };

            //pass name, hours worked and hourly rate to class

            Write("Enter Name: ");
            aDeductionsCalculator.YourName = ReadLine();

            Write("Enter Hours Worked: ");
            aDeductionsCalculator.HoursWorked = double.Parse(ReadLine()); //will convert to TryParse later. Might have to be a method in the Main (preferable in the class, maybe the set?)

            Write("Enter Hourly Rate: ");
            aDeductionsCalculator.HourlyRate = double.Parse(ReadLine());

            WriteLine("*****************************************************************************\n");

            
            //find state 

            Write("Enter State Name to Find Deductions: "); //will change later to more witty phrasing
            aDeductionsCalculator.FindStateNameID = ReadLine();

            WriteLine();

            WriteLine(aDeductionsCalculator.FindState());

            WriteLine();

            WriteLine("*****************************************************************************\n");

            WriteLine(aDeductionsCalculator.GetCalculations());
            ReadLine();
        }

        private static void GetHeadingAndInstructions()
        {
            WriteLine("*****************************************************************************");
            WriteLine("\tPay");
            WriteLine("\tHow Much is the Government Robbing You?");
            WriteLine("\tNoah Jager");
            WriteLine("\t" + DateTime.Today.ToShortDateString());
            WriteLine("*****************************************************************************\n");
            WriteLine("This program will determine pay\n");
            WriteLine("You will be asked to enter hours worked\nand rate of pay\n");
            WriteLine("*****************************************************************************");


        }
    }
}
