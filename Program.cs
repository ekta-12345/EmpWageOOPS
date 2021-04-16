using System;

namespace EmpWageOOPS
{
    class UC5WagesForMonth
    {
        public const int FULL_TIME = 1; //Constant variable

        public const int PART_TIME = 2;

        public const int EMP_RATE_PER_HOUR = 20;

        public const int NUM_OF_WORKING_DAYS = 20;

        public static void WageForMonth()

        {

            int emphrs = 0;

            int empWage = 0;

            int totalempwage = 0;

            Random random = new Random(); //Random Class

            for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)

            {

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



                empWage = EMP_RATE_PER_HOUR * emphrs; // Calculate empWage

                //Display empwage

                totalempwage = totalempwage + empWage; //Calculate total employe month wage

            }

            Console.WriteLine("Employe Wage Per Day :- " + empWage);

            Console.WriteLine("Total Employe Month Wage :- " + totalempwage);


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
            UC5WagesForMonth uC5 = new UC5WagesForMonth();
            UC5WagesForMonth.WageForMonth();
        }
    }
}

