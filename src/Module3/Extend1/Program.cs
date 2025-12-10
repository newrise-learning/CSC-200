using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend1 {
	// base class - Class we extend from
	abstract class ClassA {
		// Can inherit but cannot override
		public void Proc1() {
			Console.WriteLine("ClassA.Proc1()");
		}
		// virtual allows overidding
		// Can inherit but you can override
		public virtual void Proc2() {
			Console.WriteLine("ClassA.Proc2()");
		}
		// Cannot inherit must override
		public abstract void Proc3();
	}

	// derived class - New extended class
	class ClassB : ClassA {
		//	public new void Proc2() {	// shadowing
		public override void Proc2() {	// overriding
			base.Proc2();	// ClassA.Proc2();
			Console.WriteLine("ClassB.Proc2()");
		}
		public override void Proc3() {
			Console.WriteLine("ClassB.Proc3()");
		}
	}

	// sealed classes are final and cannot be extended
	sealed class ClassC : ClassB {
		public override void Proc2() {
			//	base.Proc2();
			Console.WriteLine("ClassC.Proc3()");
		}
		public void Proc4() {
			Console.WriteLine("ClassC.Proc4()");
		}
	}

	class Program {
		static void UseObject(ClassA obj) {
			obj.Proc1();
			obj.Proc2();
			obj.Proc3();
		}

		static void Main(string[] args) {
			// ClassA is abstract (incomplete)
			//var o1 = new ClassA();
			//o1.Proc1();	// ClassA.Proc1();
			//o1.Proc2();	// ClassA.Proc2();

			var o2 = new ClassB();
			o2.Proc1();	// ClassA.Proc1();
			o2.Proc2(); // ClassA.Proc2(); ClassB.Proc2();
			o2.Proc3(); // ClassB.Proc3();

			var o3 = new ClassC();
			o3.Proc1(); // ClassA.Proc1();
			o3.Proc2(); // ClassA.Proc2(); ClassB.Proc2();
			o3.Proc3(); // ClassB.Proc3();
			o3.Proc4(); // ClassC.Proc4();

			ClassA o4 = new ClassB();
			o4.Proc1(); // ClassA.Proc2();
		//	o4.Proc2();	// ClassA.Proc2(); shadowing does not work thru polymorphism
			o4.Proc2(); // ClassB.Proc2(); overriding works thru polymorphism


			ClassA obj1 = new ClassB();
			ClassA obj2 = new ClassC();
			ClassB obj3 = new ClassC();
			obj1.Proc2();   // ClassA.Proc2(); ClassB.Proc2();
			obj2.Proc2();   // ClassC.Proc2();
			obj3.Proc2();   // ClassC.Proc2();

			object obj4 = new ClassC();
			Console.WriteLine(obj4 is ClassC);
			Console.WriteLine(obj4 is ClassB);
			Console.WriteLine(obj4 is ClassA);

			UseObject(new ClassB());
			UseObject(new ClassC());
		}


	}
}
