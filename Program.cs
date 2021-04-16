using System;

namespace EmpWageOOPS
{
    class UC4SwitchCase
    {
        public const int FULL_TIME = 1; //Constant variable

        public const int PART_TIME = 2;

        public const int EMP_RATE_PER_HOUR = 20;

        public static void SwitchCaseStatement()

        {

            int emphrs = 0;

            int empWage = 0;

            Random random = new Random(); //Random Class

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

            Console.WriteLine("Employe Wage Per Day:- " + empWage); //Display empwage

        }


        static void Main(string[] args)
        {
            //    UC1EmpCheck uC1 = new UC1EmpCheck();
            //    uC1.PresentorAbsent();
            //UC2DailyWage uC2 = new UC2DailyWage();
            //uC2.EmployeeWage();
            //UC3EmpPartTime uC3 = new UC3EmpPartTime();
            //uC3.ParttimeEmployeeWage();
            UC4SwitchCase uC4 = new UC4SwitchCase();
            UC4SwitchCase.SwitchCaseStatement();

        }
    }
}

