using System;

class MortgageCalculator
{
    static void Main()
    {
        Console.WriteLine("Mortgage Calculator");
        Console.WriteLine("-------------------");

        // Get input values from the user
        Console.Write("Loan amount: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Interest rate (% per year): ");
        double interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Loan term (in years): ");
        int loanTerm = Convert.ToInt32(Console.ReadLine());

        // Calculate monthly interest rate
        double monthlyInterestRate = interestRate / 12;

        // Calculate number of monthly payments
        int numberOfPayments = loanTerm * 12;

        // Calculate mortgage payment using the formula for a fixed-rate mortgage
        double mortgagePayment = CalculateMortgagePayment(loanAmount, monthlyInterestRate, numberOfPayments);

        // Calculate the extra payment needed to pay off the mortgage 10 years early
        int earlyPayoffMonths = 120; // 10 years = 120 months
        int remainingPayments = numberOfPayments - earlyPayoffMonths;
        double extraPayment = CalculateExtraPayment(loanAmount, mortgagePayment, remainingPayments);

        // Display the results
        Console.WriteLine();
        Console.WriteLine("Mortgage payment: $" + mortgagePayment.ToString("F2"));
        Console.WriteLine("Extra payment needed to pay off 10 years early: $" + extraPayment.ToString("F2"));

        Console.ReadLine();
    }

    static double CalculateMortgagePayment(double loanAmount, double monthlyInterestRate, int numberOfPayments)
    {
        double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;
        return (loanAmount * monthlyInterestRate) / denominator;
    }

    static double CalculateExtraPayment(double loanAmount, double mortgagePayment, int remainingPayments)
    {
        return (loanAmount - (mortgagePayment * remainingPayments)) / remainingPayments;
    }
}
