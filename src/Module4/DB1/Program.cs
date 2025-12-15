using SymBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1 {
	class Program {
		static void Main(string[] args) {
			var item = new Account {
				ID = 300,
				Name = "XYZ PTE LTD",
				Balance = 50000m
			};
			var dc = new SymBankDataContext();
			dc.Accounts.InsertOnSubmit(item);
			dc.SubmitChanges();
		}
	}
}
