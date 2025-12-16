using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SymBank.Data {
	public static class AccountService {
		public static void Add(Account item) {
			Thread.Sleep(12000);
			var dc = new SymBankDataContext();
			dc.Accounts.InsertOnSubmit(item);
			dc.SubmitChanges();
		}
		public static Task AddAsync(Account item) {
			var task = new Task(() => Add(item));
			task.Start();
			return task;
		}

		public static void Debit(int id, decimal amount) {
			if (amount <= 0) throw new Exception("Invalid debit amount.");
			var dc = new SymBankDataContext();
			var item = dc.Accounts.Single(account => account.ID == id);
			item.Balance += amount; dc.SubmitChanges();
		}

		public static Task DebitAsync(int id, decimal amount) {
			var task = new Task(() => Debit(id, amount));
			task.Start(); return task;
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
			if (item == null) throw new Exception("Invalid account ID.");
			return item;
		}
		public static List<Account> GetList() {
			Thread.Sleep(6000);
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		}

		public static Task<List<Account>> GetListAsync() {
			var task = new Task<List<Account>>(() => GetList());
			task.Start(); return task;
		}

		//public static List<Account> GetListByName() {

		//	var dc = new SymBankDataContext();
		//	return dc.Accounts.OrderBy(account => account.Name).ToList();
		//}

		public static List<Account> ListByName {
			get {
				var dc = new SymBankDataContext();
				return dc.Accounts.OrderBy(account => account.Name).ToList();
			}
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
