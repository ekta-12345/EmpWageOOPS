using System;

namespace EmpWageOOPS
{
    class UC10ManageEmplWageOfMultipleCompanies
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        public UC10ManageEmplWageOfMultipleCompanies(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + " is :- " + totalempwage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        public int numofCompany = 0;
        private UC10ManageEmplWageOfMultipleCompanies[] UC10ManageEmplWageOfMultipleCompaniesArray;

        public EmpWageBuilderArray()
        {
            this.UC10ManageEmplWageOfMultipleCompaniesArray = new UC10ManageEmplWageOfMultipleCompanies[5];
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            UC10ManageEmplWageOfMultipleCompaniesArray[this.numofCompany] = new UC10ManageEmplWageOfMultipleCompanies(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        public void ComputeEmployeeWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                UC10ManageEmplWageOfMultipleCompaniesArray[i].setTotalEmpWage(this.ComputeEmployeeWage(this.UC10ManageEmplWageOfMultipleCompaniesArray[i]));
                Console.WriteLine(this.UC10ManageEmplWageOfMultipleCompaniesArray[i].toString());
            }
        }
        private int ComputeEmployeeWage(UC10ManageEmplWageOfMultipleCompanies UC10ManageEmplWageOfMultipleCompanies)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while (emphrs <= UC10ManageEmplWageOfMultipleCompanies.maxHoursPerMonth && workingDays < UC10ManageEmplWageOfMultipleCompanies.numOfWorkingDays)
            {

                workingDays++;
                Random random = new Random();
                int EmpCheack = random.Next(0, 3);      //Random Generate 0 ,1,2
                switch (EmpCheack)          //Switch case Statment
                {
                    case FULL_TIME:         //Employee is FullTime=1
                        emphrs = 8;
                        break;
                    case PART_TIME:          //Employee is FullTime=2
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                hrs += emphrs;

                Console.WriteLine("Day " + workingDays + " Emp hrs:- " + emphrs);//Display empwage

                //totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                //empWage = empRatePerHour * emphrs;

            }
            return emphrs * UC10ManageEmplWageOfMultipleCompanies.empRatePerHour;




        }






        static void Main(string[] args)
        {
            //    UC1EmpCheck uC1 = new UC1EmpCheck();
            //    uC1.PresentorAbsent();
            //UC2DailyWage uC2 = new UC2DailyWage();
            //uC2.EmployeeWage();
            //UC3EmpPartTime uC3 = new UC3EmpPartTime();
            //uC3.ParttimeEmployeeWage();
            //UC4SwitchCase uC4 = new UC4SwitchCase();
            //UC4SwitchCase.SwitchCaseStatement();
            //UC5WagesForMonth uC5 = new UC5WagesForMonth();
            //UC5WagesForMonth.WageForMonth();
            //UC6WageMaxHours uC6 = new UC6WageMaxHours();
            //UC6WageMaxHours.WagesCondition();
            //UC7CodeRefractor uC7 = new UC7CodeRefractor();
            //UC7CodeRefractor.ComputeEmployeeWage();
            //UC8WageMultipleCompanies uC8 = new UC8WageMultipleCompanies();
            //UC8WageMultipleCompanies.ComputeEmpWage("Amazon",20,4,20);
            //UC8WageMultipleCompanies.ComputeEmpWage("Infosys", 30, 6, 20);
            //UC9StoreWageMultpleCompanies Dmart = new UC9StoreWageMultpleCompanies("Dmart", 20, 4, 20);
            //UC9StoreWageMultpleCompanies Reliance = new UC9StoreWageMultpleCompanies("Reliance", 30, 5, 20);
            //Dmart.ComputeEmployeeWage(); //call method
            //Console.WriteLine(Dmart.toString());
            //Reliance.ComputeEmployeeWage();//call method
            //Console.WriteLine(Reliance.toString());
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();   //Create object of class
            empWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            empWageBuilder.addComapnyEmpWage("Reliance", 10, 4, 20); //call method
            empWageBuilder.ComputeEmployeeWage(); //call method
        }
    }
}


