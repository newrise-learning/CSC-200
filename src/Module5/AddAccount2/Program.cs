using SymBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAccount2 {
	class Program {
		static int Main(string[] args) {
			try {
				if (args.Length != 3)
					throw new Exception("Invalid number of arguments.");
				Account item = new Account {
					ID = int.Parse(args[0]),
					Name = args[1],
					Balance = decimal.Parse(args[2])
				};
				AccountService.Add(item);
				Console.WriteLine("Account {0} added successfully!", item.ID);
				return 0;	// Environment.Exit(0);
			}
			catch (Exception ex) {
				Console.WriteLine("Could not add new account." + ex.Message);
				return 1;	// Environment.Exit(1);
			}
		}
	}
}
