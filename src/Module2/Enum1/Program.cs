using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1 {
	public enum Gender {
		Female,	// default to 0
		Male	// previous item + 1
	}

	public enum AsiaCallCode {
		Australia = 61,
		Indonesia,	// 62 (Australia + 1)
		Phillipines, // 63 (Indonesia + 1)
		Brunei = 615,
		China = 86,
		NewZealand = 64,
		Singapore,	// 65 (NewZealand + 1)
		Taiwan = 886,
		Thailand = 66,
		Vietnam = 84,
		Malaysia = 60,
		Myanmar = 95,
		Japan = 81
	}


	class Program {
		public static void Main() { 
			Gender g = Gender.Male;
			AsiaCallCode a = AsiaCallCode.Malaysia;
			AsiaCallCode b = (AsiaCallCode)84;
			Console.WriteLine(g);
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine((int)g);
			Console.WriteLine((int)a);
			Console.WriteLine((int)b);

		}
	}
}
