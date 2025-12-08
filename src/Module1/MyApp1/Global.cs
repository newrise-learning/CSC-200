using C = System.Console;
using MsgBox = System.Windows.Forms.MessageBox;

namespace Symbolicon.Examples
{
	struct Global
	{
		static void Main()
		{
			// This content will not be compiled until end-of-line
			/* Any content within here will not be compiled */

			C.WriteLine("Hello!");
			C.WriteLine("Goodbye!");
			C.Write("Press any key to continue...");
			C.ReadKey(true);
			MsgBox.Show("Click OK to continue.");
		}
	}
}

