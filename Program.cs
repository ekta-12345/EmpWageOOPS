using System;

namespace EmpWageOOPS
{
    class UC3EmpPartTime
    {
        public void ParttimeEmployeeWage()

        {

            int FULL_TIME = 1;

            int PART_TIME = 2;

            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;

            int empWage = 0;

            Random random = new Random();

            int EmpCheack = random.Next(0, 3);

            if (EmpCheack == FULL_TIME)

            {

                emphrs = 8;



            }

            else if (EmpCheack == PART_TIME)

            {

                emphrs = 4;

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
            //UC2DailyWage uC2 = new UC2DailyWage();
            //uC2.EmployeeWage();
            UC3EmpPartTime uC3 = new UC3EmpPartTime();
            uC3.ParttimeEmployeeWage();

        }
    }
}

