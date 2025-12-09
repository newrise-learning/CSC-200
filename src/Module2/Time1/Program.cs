using MyLib1;
using System;

class Program {
	static void Main() {
		var a = new Time();
		var b = new Time();
		a.Hour = 10; a.Minute = 20; a.Second = 30;
		b.Hour = 11; b.Minute = 22; b.Second = 33;
		Console.WriteLine("{0:00}:{1:00}:{2:00}", a.Hour, a.Minute, a.Second);
		Console.WriteLine("{0:00}:{1:00}:{2:00}", b.Hour, b.Minute, b.Second);

		var t = new Time();
		t.Hour = 23;
		t.Minute = 59;
		t.Second = 59;
		Console.WriteLine("{0:00}:{1:00}:{2:00}", t.Hour, t.Minute, t.Second);
		Console.WriteLine(a.Value);	// converts time to seconds
		Console.WriteLine(b.Value);
		Console.WriteLine(t.Value);

		t.Value = 128489;   // converts seconds back to time
		t.Value += 3660;	// add one hour and one minute
		Console.WriteLine("{0:00}:{1:00}:{2:00}", t.Hour, t.Minute, t.Second);

		//	var c = new Time();
		//	var c = new Time(1, 2, 3);
		var c = new Time(13450);
		Console.WriteLine("{0:00}:{1:00}:{2:00}", c.Hour, c.Minute, c.Second);
		c.SetTime(10, 20, 30);
		c.SetTime(10, 20);  // c.SetTime(10, 20, 0);
		c.SetTime(10);  // c.SetTime(10, 0, 0);
		c.SetTime();  // c.SetTime(0, 0, 0);
	//	(Passing parameters by name)
	//	Skip past any parameter that has a default value
	//	Pass parameters in any order
		c.SetTime(second: 30);
		c.SetTime(second: 30, hour: 10);

		short h, m, s;
		c.GetTime(out h, out m, out s);
		Console.WriteLine(h);
		Console.WriteLine(m);
		Console.WriteLine(s);
		Console.WriteLine(c.Value);
		c.Add(60);
		c.Subtract(3600);
		Console.WriteLine(c.Value);
	}
}
