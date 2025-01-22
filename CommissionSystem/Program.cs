namespace CommissionSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Empoylee data starts here
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();


            string ssn;
            // validate SSN input using validationHelper
            while (true)
            {
                Console.WriteLine("enter your Social Security Number (xxx-xx-xxxx):");
                ssn = Console.ReadLine();
                if (Validationhelper.IsValidSSN(ssn))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid SSN Format. Please enter it in the format xxx-xx-xxx.");
                }
            }

            decimal commissionRate;
            // Validate commission Rate input using validationhelper
            while (true)
            {
                Console.WriteLine("Enter Commision rate (as decimal, e.g., 0.1 for 10%:");

                // Read the user input as a string
                string commissionRateInput = Console.ReadLine();

                // Check if input is a claid decimal and ensures it's not a whole number
                if (decimal.TryParse(commissionRateInput, out commissionRate) && commissionRate > 0)
                {
                    if (commissionRate % 1 != 0)
                    {
                        break; // breaks loop if commision rate is valid and contains a decimal point
                    }
                }
                else
                {
                    Console.WriteLine("invlaid commission Rate. it must be a positive number greater than 0.");
                }
            }
                decimal baseSalary;
                // validdate base salary input (should be positive)
                while (true)
                {
                    Console.WriteLine("enter base salary:");
                    if (decimal.TryParse(Console.ReadLine(), out baseSalary) && baseSalary >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid base salary. please enter a valid postive number.");
                    }
                }
                decimal grossSales;
                while (true)
                {
                    Console.WriteLine("Enter Gross Sales:");
                if (decimal.TryParse(Console.ReadLine(), out grossSales) && grossSales >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Gross Sales. please enter a valid pstive number.");
                }
                }
            CommissionEmpoylee employee = new CommissionEmpoylee(firstName, lastName, ssn, commissionRate, baseSalary);
            employee.SetGrossSales(grossSales);

            decimal totalEarnings = employee.CalculateEarnings();
            Console.WriteLine($"Total Earnings for {employee.Firstname} {employee.Lastname} {totalEarnings:C}");

            Console.ReadKey();
        }
    }
}
