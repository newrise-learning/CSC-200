using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3 {
	class Valueable<T> where T : struct {
		private T _value;

		public T Value {
			get { return _value; }
			set {
				if (!_value.Equals(value))
					_value = value;
			}
		}

		public Valueable() { }
		public Valueable(T value) {
			_value = value;
		}
		public void Reset() {
			_value = default(T);
		}
	}

	class Program {
		static void Main(string[] args) {
			var v1 = new Valueable<int>(66);
			var v2 = new Valueable<double>(99.1);
			var v3 = new Valueable<bool>(true);
			Console.WriteLine(v1.Value);
			Console.WriteLine(v2.Value);
			Console.WriteLine(v3.Value);
			v1.Reset();
			v2.Reset();
			v3.Reset();
			Console.WriteLine(v1.Value);
			Console.WriteLine(v2.Value);
			Console.WriteLine(v3.Value);
			v1 = null;
			v2 = null;
			v3 = null;
		}
	}
}
