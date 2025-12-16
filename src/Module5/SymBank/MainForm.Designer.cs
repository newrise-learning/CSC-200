namespace SymBank {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnTransfer = new System.Windows.Forms.Button();
			this.btnCredit = new System.Windows.Forms.Button();
			this.btnDebit = new System.Windows.Forms.Button();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtTargetID = new System.Windows.Forms.TextBox();
			this.txtSourceID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grdAccounts = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnFind);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.txtBalance);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(673, 194);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Information";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(528, 94);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(122, 32);
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "&Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(528, 46);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(122, 32);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point(187, 135);
			this.txtBalance.MaxLength = 10;
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(137, 32);
			this.txtBalance.TabIndex = 5;
			this.txtBalance.Text = "0";
			this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(187, 89);
			this.txtName.MaxLength = 30;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(278, 32);
			this.txtName.TabIndex = 3;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(187, 46);
			this.txtID.MaxLength = 4;
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 32);
			this.txtID.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Balance";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "&ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.btnTransfer);
			this.groupBox2.Controls.Add(this.btnCredit);
			this.groupBox2.Controls.Add(this.btnDebit);
			this.groupBox2.Controls.Add(this.txtAmount);
			this.groupBox2.Controls.Add(this.txtTargetID);
			this.groupBox2.Controls.Add(this.txtSourceID);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(13, 230);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(673, 213);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Transaction Information";
			// 
			// btnTransfer
			// 
			this.btnTransfer.Location = new System.Drawing.Point(528, 152);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Size = new System.Drawing.Size(122, 32);
			this.btnTransfer.TabIndex = 8;
			this.btnTransfer.Text = "T&ransfer";
			this.btnTransfer.UseVisualStyleBackColor = true;
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// btnCredit
			// 
			this.btnCredit.Location = new System.Drawing.Point(528, 99);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Size = new System.Drawing.Size(122, 32);
			this.btnCredit.TabIndex = 7;
			this.btnCredit.Text = "&Credit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// btnDebit
			// 
			this.btnDebit.Location = new System.Drawing.Point(528, 48);
			this.btnDebit.Name = "btnDebit";
			this.btnDebit.Size = new System.Drawing.Size(122, 32);
			this.btnDebit.TabIndex = 6;
			this.btnDebit.Text = "&Debit";
			this.btnDebit.UseVisualStyleBackColor = true;
			this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(187, 149);
			this.txtAmount.MaxLength = 10;
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(100, 32);
			this.txtAmount.TabIndex = 5;
			this.txtAmount.Text = "0";
			this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTargetID
			// 
			this.txtTargetID.Location = new System.Drawing.Point(187, 96);
			this.txtTargetID.MaxLength = 4;
			this.txtTargetID.Name = "txtTargetID";
			this.txtTargetID.Size = new System.Drawing.Size(100, 32);
			this.txtTargetID.TabIndex = 3;
			// 
			// txtSourceID
			// 
			this.txtSourceID.Location = new System.Drawing.Point(187, 45);
			this.txtSourceID.MaxLength = 4;
			this.txtSourceID.Name = "txtSourceID";
			this.txtSourceID.Size = new System.Drawing.Size(100, 32);
			this.txtSourceID.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 25);
			this.label6.TabIndex = 4;
			this.label6.Text = "A&mount";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "&Target ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "&Source ID";
			// 
			// grdAccounts
			// 
			this.grdAccounts.AllowUserToAddRows = false;
			this.grdAccounts.AllowUserToDeleteRows = false;
			this.grdAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdAccounts.Location = new System.Drawing.Point(706, 25);
			this.grdAccounts.Name = "grdAccounts";
			this.grdAccounts.ReadOnly = true;
			this.grdAccounts.RowTemplate.Height = 24;
			this.grdAccounts.Size = new System.Drawing.Size(582, 369);
			this.grdAccounts.TabIndex = 2;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.Location = new System.Drawing.Point(1166, 411);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(122, 32);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "Refres&h";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 465);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.grdAccounts);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MinimumSize = new System.Drawing.Size(1318, 512);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account System";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnTransfer;
		private System.Windows.Forms.Button btnCredit;
		private System.Windows.Forms.Button btnDebit;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtTargetID;
		private System.Windows.Forms.TextBox txtSourceID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView grdAccounts;
		private System.Windows.Forms.Button btnRefresh;
	}
}

