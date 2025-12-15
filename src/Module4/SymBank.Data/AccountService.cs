using System;
using System.Collections.Generic;
using System.Linq;

namespace SymBank.Data {
	public static class AccountService {
		public static void Add(Account item) {
			var dc = new SymBankDataContext();
			dc.Accounts.InsertOnSubmit(item);
			dc.SubmitChanges();
		}
		public static void Debit(int id, decimal amount) {
			if (amount <= 0) throw new Exception("Invalid debit amount.");
			var dc = new SymBankDataContext();
			var item = dc.Accounts.Single(account => account.ID == id);
			item.Balance += amount; dc.SubmitChanges();
		}
		public static void Credit(int id, decimal amount) {
			if (amount <= 0) throw new Exception("Invalid debit amount.");
			var dc = new SymBankDataContext();
			var item = dc.Accounts.Single(account => account.ID == id);
			item.Balance -= amount; dc.SubmitChanges();
		}
		public static void Remove(int id) {
			var dc = new SymBankDataContext();
			var item = dc.Accounts.Single(account => account.ID == id);
			dc.Accounts.DeleteOnSubmit(item);
			dc.SubmitChanges();
		}
		public static void Transfer(int source, int target, decimal amount) {
			var dc = new SymBankDataContext();
			dc.Transfer(source, target, amount);
		}
		public static Account GetItem(int id) {
			var dc = new SymBankDataContext();
			//	return dc.Accounts.Single(account => account.ID == id);
			Account item = dc.Accounts.SingleOrDefault(account => account.ID == id);
			if (item == null) throw new Exception("Account does not exist.");
			return item;
		}
		public static List<Account> GetList() {
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		}
		//public static string[] GetNameList() {
		//	var dc = new SymBankDataContext();
		//	return dc.Accounts
		//		.Where(account => account.Balance > 0)
		//		.OrderBy(account => account.Name)
		//		.Select(account => account.Name)
		//		.Distinct().ToArray();
		//}
		public static string[] GetNameList() {
			var dc = new SymBankDataContext();
			return (from account in dc.Accounts
					where account.Balance > 0
					orderby account.Name
					select account.Name).Distinct().ToArray();
		}
		public static int Count {
			get {
				var dc = new SymBankDataContext();
				return dc.Accounts.Count();
			}
		}
		public static int NonZeroCount {
			get {
				var dc = new SymBankDataContext();
				return dc.Accounts.Count(account => account.Balance > 0);
			}
		}
		public static decimal TotalBalance {
			get {
				var dc = new SymBankDataContext();
				return dc.Accounts
					.Where(account => account.Balance > 0)
					.Sum(account => account.Balance);
			}
		}

	}
}
