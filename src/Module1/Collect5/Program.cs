using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect5
{
	class Program
	{
		static void Main(string[] args)
		{
		//	Stack<int> s = new Stack<int>();
		//	Queue<int> q = new Queue<int>();
			var s = new Stack<int>();
			var q = new Queue<int>();
			s.Push(100);
			s.Push(200);
			s.Push(300);
			q.Enqueue(100);
			q.Enqueue(200);
			q.Enqueue(300);
			Console.WriteLine(s.Count); // 3
			Console.WriteLine(q.Count); // 3
			Console.WriteLine(s.Peek()); // top of the stack (300)
			Console.WriteLine(q.Peek()); // front of the queue (100)
			while (s.Count > 0) Console.WriteLine(s.Pop());		// 300,200,100
			while (q.Count > 0) Console.WriteLine(q.Dequeue());	// 100,200,300


		}
	}
}
