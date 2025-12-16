using System;
using System.Windows.Forms;

namespace SymBank {
	public static class UIExtensions {
		public static int GetInt32(this TextBox control, string error) {
			int value = 0;
			if (int.TryParse(control.Text, out value)) return value;
			control.Focus(); throw new Exception(error);
		}
		public static decimal GetDecimal(this TextBox control, string error) {
			decimal value = 0;
			if (decimal.TryParse(control.Text, out value)) return value;
			control.Focus(); throw new Exception(error);
		}
		public static string GetNotEmpty(this TextBox control, string error) {
			string value = control.Text.Trim();
			if (value.Length > 0) return value;
			control.Focus(); throw new Exception(error);
		}
	}
}
