using System;
using System.Globalization;
using Exercicio_Execoes.Entities.Exeptions;
using Exercicio_Execoes.Entities;
namespace Exercicio_Execoes {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("Enter Account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter Amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New Balance: "+account.Balance);
                }
            catch(DomainExeption e) {
                Console.WriteLine("Erro in withdraw: " + e.Message);
                }
            }
        }
    }
