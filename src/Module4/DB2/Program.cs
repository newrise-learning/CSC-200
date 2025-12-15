using SymBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2 {
	class Program {
		static void Main(string[] args) {
			var list = AccountService.GetList();
			foreach (Account item in list)
				Console.WriteLine(
					"{0:0000} {1,-30} {2,10:C2}",
					item.ID, item.Name, item.Balance);
		}
	}
}
