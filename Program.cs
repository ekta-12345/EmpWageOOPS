using System;

namespace EmpWageOOPS
{
    class UC2DailyWage
    {
        public void EmployeeWage()

        {

            int PRESENT = 1;

            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;

            int empWage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == PRESENT)

            {

                emphrs = 8;



            }

            else

            {

                emphrs = 0;

            }

            empWage = EMP_RATE_PER_HOUR * emphrs;

            Console.WriteLine("Employe Wage Per Day:- " + empWage);

        }
        static void Main(string[] args)
        {
            //    UC1EmpCheck uC1 = new UC1EmpCheck();
            //    uC1.PresentorAbsent();
            UC2DailyWage uC2 = new UC2DailyWage();
            uC2.EmployeeWage();

        }
    }
}

