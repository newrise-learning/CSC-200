using SymBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAccount1 {
	class Program {
		static void Main(string[] args) {
			try {
				Account item = new Account();
				Console.Write("ID:"); item.ID = int.Parse(Console.ReadLine());
				Console.Write("Account:"); item.Name = Console.ReadLine();
				Console.Write("Balance:"); item.Balance = decimal.Parse(Console.ReadLine());
				AccountService.Add(item);
				Console.WriteLine(
					"Account {0} added successfully!",
					item.ID);
			}
			catch (Exception ex) {
#if DEBUG
				Console.WriteLine(ex.Message);
#else
				Console.WriteLine(
					"Could not add new account." + ex.Message);
#endif
			}
		}
	}
}
