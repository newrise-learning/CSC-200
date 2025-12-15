using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2 {
	class Program {
		static void Proc1(int value) {  }
		static void Proc2(string value) { }
		static void Proc3(bool value) { }

		//delegate void IntHandler(int v);
		//delegate void StringHandler(string v);
		//delegate void BoolHandler(bool v);

		delegate void Handler<T1>(T1 v);
		delegate void Handler<T1,T2>(T1 v1, T2 v2);

		static void Main(string[] args) {
			//IntHandler d1 = Proc1;
			//StringHandler d2 = Proc2;
			//BoolHandler d3 = Proc3;
			Handler<int> d1 = Proc1;
			Handler<string> d2 = Proc2;
			Handler<bool> d3 = Proc3;
			d1(123);
			d2("Hello!");
			d3(true);

		}
	}
}
