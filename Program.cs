using System;
using System.Globalization;
using CarRental.Entities;
using CarRental.Services;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int n = int.Parse(Console.ReadLine());

            Contract contracts = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contracts, n);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contracts.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
