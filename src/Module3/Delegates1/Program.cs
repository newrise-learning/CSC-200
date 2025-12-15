using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates1 {
//	public delegate void ProgressHandler(int status);

	class Job {
		//	public event ProgressHandler OnProgressChanged;
		public event Action<int> OnProgressChanged;

		public void Run() {
			// simulate 20 seconds of work
			// Thread.Sleep(20000);
			for (int i = 1; i <= 100; i++) {
				Thread.Sleep(200);
			if (OnProgressChanged != null)
				OnProgressChanged(i);
			}
		}
	}
	class Program {
		//static void ShowProgress1(int status) {
		//	Console.SetCursorPosition(0, 0);
		//	Console.WriteLine("{0,3}% completed!", status);
		//}
		//static void ShowProgress2(int status) {
		//	Console.SetCursorPosition(0, 1);
		//	Console.WriteLine("{0,3}% work left!", 100 - status);
		//}
		static void Main(string[] args) {
			Job job1 = new Job();
			Console.Clear();
			//	job1.OnProgressChanged += ShowProgress1;
			//	job1.OnProgressChanged += ShowProgress1;
			//job1.OnProgressChanged += delegate (int status) {
			//	Console.SetCursorPosition(0, 0);
			//	Console.WriteLine("{0,3}% completed!", status);
			//};
			//job1.OnProgressChanged += delegate (int status) {
			//	Console.SetCursorPosition(0, 1);
			//	Console.WriteLine("{0,3}% work left!", 100 - status);
			//};
			job1.OnProgressChanged += status => {
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("{0,3}% completed!", status);
			};
			job1.OnProgressChanged += status => {
				Console.SetCursorPosition(0, 1);
				Console.WriteLine("{0,3}% work left!", 100 - status);
			};
			job1.Run();
		}
	}
}
