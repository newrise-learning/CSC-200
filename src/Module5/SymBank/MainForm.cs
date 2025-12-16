using SymBank.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymBank {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		public void Success(string message) {
			MessageBox.Show(this, message, "Information",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void Failure(string message) {
			MessageBox.Show(this, message, "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void ResetAccountForm() {
			txtID.Text = string.Empty;
			txtName.Text = string.Empty;
			txtBalance.Text = "0";
			txtID.Focus();
		}

		public void ResetTransactionForm() {
			txtSourceID.Text = string.Empty;
			txtTargetID.Text = string.Empty;
			txtAmount.Text = "0";
			txtSourceID.Focus();
		}

		private async void btnAdd_Click(object sender, EventArgs e) {
			try {
				btnAdd.Enabled = false;
				Account item = new Account {
					ID = txtID.GetInt32("ID must be an integer."),
					Name = txtName.GetNotEmpty("Name cannot be empty."),
					Balance = txtBalance.GetDecimal("Opening balance must be a number.")
				};
				await AccountService.AddAsync(item);
				Success("Account has been added.");
				ResetAccountForm();
			}
			catch (Exception ex) {
				Failure("Cannot add account. " + ex.Message);
			}
			finally {
				btnAdd.Enabled = true;
			}
		}

		private void btnFind_Click(object sender, EventArgs e) {
			try {
				btnFind.Enabled = false;
				Account item = AccountService.GetItem(
					int.Parse(txtID.Text));
				txtName.Text = item.Name;
				txtBalance.Text = item.Balance.ToString("N2");
				txtID.Focus();
			}
			catch (Exception ex) {
				Failure("Cannot find account. " + ex.Message);
				ResetAccountForm();
			}
			finally {
				btnFind.Enabled = true;
			}
		}

		private void btnDebit_Click(object sender, EventArgs e) {
			try {
				btnDebit.Enabled = false;
				AccountService.Debit(
					int.Parse(txtSourceID.Text),
					decimal.Parse(txtAmount.Text));
				Success("Account has been debited.");
				ResetTransactionForm();
			}
			catch (Exception ex) {
				var balance = decimal.Parse(txtAmount.Text);
				if (balance < 0) {
					Failure("Amount cannot be negative.");
					txtAmount.Text = "0";
					txtAmount.Focus();
				} else Failure("Cannot debit account. " + ex.Message);
			}
			finally {
				btnDebit.Enabled = true;
			}
		}

		private void btnCredit_Click(object sender, EventArgs e) {
			try {
				btnCredit.Enabled = false;
				AccountService.Credit(
					int.Parse(txtSourceID.Text),
					decimal.Parse(txtAmount.Text));
				Success("Account has been credited.");
				ResetTransactionForm();
			} catch (Exception ex) {
				var balance = decimal.Parse(txtAmount.Text);
				if (balance < 0) {
					Failure("Amount cannot be negative.");
					txtAmount.Text = "0";
					txtAmount.Focus();
				} else Failure("Cannot credit account. " + ex.Message);
			} finally {
				btnCredit.Enabled = true;
			}
		}

		private void btnTransfer_Click(object sender, EventArgs e) {
			try {
				btnTransfer.Enabled = false;
				AccountService.Transfer(
					int.Parse(txtSourceID.Text),
					int.Parse(txtTargetID.Text),
					decimal.Parse(txtAmount.Text));
				Success("Amount has been transferred.");
				ResetTransactionForm();
			} catch (Exception ex) {
				Failure("Cannot transfer amount. " + ex.Message);
			} finally {
				btnTransfer.Enabled = true;
			}
		}

		private async void btnRefresh_Click(object sender, EventArgs e) {
			try {
				btnRefresh.Enabled = false;
				var list = await AccountService.GetListAsync();
				grdAccounts.DataSource = list;
			}
			catch (Exception ex) {
				Failure("Cannot retrieve accounts. " + ex.Message);
			}
			finally {
				btnRefresh.Enabled = true;
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			btnRefresh_Click(sender, e);
		}
	}
}
