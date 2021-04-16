using System;

namespace EmpWageOOPS
{
    class UC8WageMultipleCompanies
    {
        public const int FULL_TIME = 1; //Constant variable

        public const int PART_TIME = 2;

        // public const int EMP_RATE_PER_HOUR = 20;

        //public const int MAX_WORKING_HRS = 100;

        // public const int MAX_WORKING_DAYS = 20;

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)

        {

            int emphrs = 0;

            int empWage = 0;

            int totalempwage = 0;

            int hrs = 0;

            int workingDays = 1;

            Random random = new Random(); //Random Class

            while (hrs < empRatePerHour && numOfWorkingDays <= maxHoursPerMonth)

            // for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)

            {



                workingDays++;

                int EmpCheack = random.Next(0, 3); //Random Generate 0 ,1,2

                switch (EmpCheack) //Switch case Statment

                {

                    case FULL_TIME: //Employee is FullTime=1

                        emphrs = 8;

                        break;

                    case PART_TIME: //Employee is FullTime=2

                        emphrs = 4;

                        break;

                    default:

                        emphrs = 0;

                        break;

                }



                // Calculate empWage

                hrs += emphrs; //Display empwage

                totalempwage = totalempwage + empWage; //Calculate total employe month wage

                empWage = empRatePerHour * emphrs;

            }



            Console.WriteLine($"Toatal Emp wage for company:- {company} is {totalempwage}");

            Console.WriteLine("Employe Wage Per Day :- " + empWage);

            //Console.WriteLine("Total Employe Month Wage :- " + totalempwage);

            // Console.WriteLine("Employee wage for " + workingDays + " days " + totalempwage);

            Console.WriteLine("Working hours " + hrs + "\n");

            return totalempwage;



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
            UC8WageMultipleCompanies uC8 = new UC8WageMultipleCompanies();
            UC8WageMultipleCompanies.ComputeEmpWage("Amazon",20,4,20);
            UC8WageMultipleCompanies.ComputeEmpWage("Infosys", 30, 6, 20);
        }
    }
}


