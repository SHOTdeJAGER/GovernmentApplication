using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GovernmentRobbingUs_Noah_BIll
{
    class DeductionsCalculator
    {

        /// <summary>
        /// These will be parallel arrays that store information
        /// regarding the state and the associated taxes.
        /// The subscripts will match (parallel) and will be further used 
        /// for extraction and calculations.
        /// We can always add more arrays and information once we get this down. 
        /// 
        /// ****Things To Add****
        /// Additional (and factual) values for the deductions;
        /// More deductions, if applicable;
        /// MessageBox alerts (Windows.Forms references);
        /// Improve console app view; 
        /// TryParse methods for data entry;
        /// while loops so we can cycle re-entry of data; 
        /// </summary>

        //Main will send all the arrays through to class

        string[] stateNameArray; 
        double[] ficaTaxArray;
        double[] fedTaxArray;
        double[] stateTaxArray;
        double[] healthInsurArray;

        //Input variables sent from Main

        string yourName;
        string stateNameID; //value used to search and set index
        double hoursWorked;
        double hourlyRate;

        //output variables calculated in Class

        double grossPay;
        double ficaTaxDeduction;
        double federalTaxDeduction;
        double stateTaxDeduction;
        double healthInsurDeduction;
        double netPay;

        public DeductionsCalculator()
        {
            // empty 
        } //end constructor 

        public string[] StateName
        {
            set
            {
                stateNameArray = value;
            }
        } //set state name(s) from Main

        public double[] FicaTax
        {
            set
            {
                ficaTaxArray = value;
            }
        } //set FICA tax(es) from Main

        public double[] FedTax
        {
            set
            {
                fedTaxArray = value;
            }
        } //set Federal tax(es) from Main

        public double[] StateTax
        {
            set
            {
                stateTaxArray = value;
            }
        } //set State tax(es) from Main

        public double[] HealthInsurance
        {
            set
            {
                healthInsurArray = value;
            }
        } //set Health Insurance(s) from Main

        public string YourName
        {
            set
            {
                yourName = value;
            }
        } //set yourName from Main

        public double HoursWorked
        {
            set
            {
                hoursWorked = value;
            }
        } //set hours worked from Main

        public double HourlyRate
        {
            set
            {
                hourlyRate = value;
            }
        } //set pay rate (hourly rate) from Main

        public string FindStateNameID
        {
            set
            {
                stateNameID = value.ToUpper(); //converts the input value to upper case (using upper case state abbreviations in StateName array)
            }
        } //set state name search ID from Main

        public string FindState()
        {
            //Should create while loop to create cycle for re-entry 
            //find postion of the stateNameID

            bool found;
            string strOne = " ";
            //double stateResults = 0;
            double ficaResults = 0;
            double fedResults = 0;
            double stateTaxResults = 0;
            double healthResults = 0;

            int index = Array.IndexOf(stateNameArray, stateNameID);
            if (index == -1) //not found 
            {
                found = false;
            }
            else
            {
                found = true;
                ficaResults = ficaTaxArray[index];
                fedResults = fedTaxArray[index];
                stateTaxResults = stateTaxArray[index];
                healthResults = healthInsurArray[index];


            } //results if found. Displays parallel results of the array as deducation percentages

            if (found == false)
            {
                return "\t\tNot Found!\n"; //I want to add a Windows.Forms reference to allow for a message box alert here
            }
            else
            {
                strOne += string.Format("\n\tFica Tax\t{0:P}", ficaResults);
                strOne += string.Format("\n\tFederal Tax\t{0:P}", fedResults);
                strOne += string.Format("\n\tState Tax\t{0:P}", stateTaxResults);
                strOne += string.Format("\n\tHealth Insur\t{0:P}", healthResults);

                return strOne;
            }

        }

        public void SetGrossPayCalculation()
        {
            grossPay = hoursWorked * hourlyRate;
        }

        public double GetGrossPay
        {
            get
            {
                SetGrossPayCalculation();
                return grossPay;
            }
        } //get value from the gross pay calculation

        public string GetCalculations()
        {
            //Should create a while loop to allow for State re-entry 
            SetGrossPayCalculation(); //need to call this in order to prevent "0" from being passed 

            bool found;
            string strTwo = " ";
            string strThree = " ";
            double ficaResults;
            double fedResults;
            double stateTaxResults;
            double healthResults;
           

            int index = Array.IndexOf(stateNameArray, stateNameID);
            if (index == -1) //not found 
            {
                found = false;

            }
            else
            {
                found = true;
                ficaResults = ficaTaxArray[index];
                fedResults = fedTaxArray[index];
                stateTaxResults = stateTaxArray[index];
                healthResults = healthInsurArray[index];

                //Calculations for all deductions and net pay

                ficaTaxDeduction = grossPay * ficaResults;
                federalTaxDeduction = grossPay * fedResults;
                stateTaxDeduction = grossPay * stateTaxResults;
                healthInsurDeduction = grossPay * healthResults;
                netPay = grossPay - (ficaTaxDeduction + federalTaxDeduction + stateTaxDeduction + healthInsurDeduction);

            }
            if (found == false)
            {
                strTwo += string.Format("\tNo Calculation Performed!\n");
                
                return strTwo;
            }
            else
            {
                strThree += string.Format("\tThe Government Has Robbed You This Much\n\n");
                strThree += string.Format("Name:\t\t {0}\n\n", yourName);
                strThree += string.Format("Gross Pay:\t {0:C}\n", grossPay);
                strThree += string.Format("FICA Tax:\t {0:C}\n", ficaTaxDeduction);
                strThree += string.Format("Federal Tax:\t {0:C}\n", federalTaxDeduction);
                strThree += string.Format("State Tax:\t {0:C}\n", stateTaxDeduction);
                strThree += string.Format("HealthInsurance  {0:C}\n", healthInsurDeduction);
                strThree += string.Format("Net Pay\t\t {0:C}\n", netPay);

               
            }
            return strThree;
        }

    }
}
