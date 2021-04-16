using System;

namespace EmpWageOOPS
{
    class UC1EmpCheck
    {
        public void PresentorAbsent()

        {
            Random random = new Random();

            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == 1)

            {

                Console.WriteLine("Employee Is Present");



            }

            else

            {

                Console.WriteLine("Employe Is Absent");

            }

        }
        static void Main(string[] args)
        {
            UC1EmpCheck uC1 = new UC1EmpCheck();
            uC1.PresentorAbsent();
        }

    }

}

