using System;
using System.Xml.Serialization;

namespace MyLib1 {
	[Serializable]
	public class Time :
			ICloneable,
			ICloneable<Time>,
			IComparable,
			IComparable<Time>,
			IComparable<int> {
		#region consts
		public const int MinHour = 0;
		public const int MinMinute = 0;
		public const int MinSecond = 0;
		public const int MaxHour = 23;
		public const int MaxMinute = 59;
		public const int MaxSecond = 59;
		#endregion
		#region fields
		#region object fields
		private short hour;
		private short minute;
		private short second;
		#endregion
		#region static fields
		public static Time Midnight {
			get {
				return new Time(0, 0, 0);
			}
		}
		public static Time Afternoon {
			get {
				return new Time(12, 0, 0);
			}
		}
		#endregion
		#endregion
		#region properties
		#region object properties
		public short Hour {
			get {
				return hour;
			}
			set {
				if (value < MinHour || value > MaxHour)
					throw new Exception("Invalid hour value.");
				hour = value;
			}
		}
		public short Minute {
			get {
				return minute;
			}
			set {
				if (value < MinMinute || value > MaxMinute)
					throw new Exception("Invalid minute value.");
				minute = value;
			}
		}
		public short Second {
			get {
				return second;
			}
			set {
				if (value < MinSecond || value > MaxSecond)
					throw new Exception("Invalid second value.");
				second = value;
			}
		}
		[XmlIgnore]
		public int Value {
			get {
				return hour * 3600 +
					minute * 60 +
					second;
			}
			set {
				if (value < 0)
					throw new Exception("Invalid time value.");
				hour = (short)(value / 3600 % 24);
				minute = (short)(value % 3600 / 60);
				second = (short)(value % 60);
			}
		}
		#endregion
		#region static properties
		//	public static readonly Time Midnight;
		//	public static readonly Time Afternoon;

		#endregion
		#endregion
		#region constructors
		#region object constructors
		public Time() {
			var dt = DateTime.Now;
			hour = (short)dt.Hour;
			minute = (short)dt.Minute;
			second = (short)dt.Second;
		}
		public Time(short hour, short minute, short second) {
			Hour = hour;
			Minute = minute;
			Second = second;
		}
		public Time(int value) {
			Value = value;
		}
		#endregion
		#region static constructor
		static Time() {
			//Midnight = new Time(0, 0, 0);
			//Afternoon = new Time(12, 0, 0);
		}
		#endregion
		#endregion
		#region methods
		public void SetTime(short hour = 0, short minute = 0, short second = 0) {
			Hour = hour;
			Minute = minute;
			Second = second;
		}
		//public void SetTime(short hour, short minute) {
		//	//Hour = hour;
		//	//Minute = minute;
		//	//second = 0;
		//	SetTime(hour, minute, 0);
		//}
		//public void SetTime(short hour) {
		//	//Hour = hour;
		//	//minute = 0;
		//	//second = 0;
		//	SetTime(hour, 0);
		//}
		public void GetTime(out short hour, out short minute, out short second) {
			//	hour = Hour;
			//	minute = Minute;
			//	second = Second;
			hour = this.hour;
			minute = this.minute;
			second = this.second;
		}
		public void Add(int seconds) {
			if (seconds < 0) throw new Exception("Invalid seconds parameter.");
			//	Value = Value + seconds;
			Value += seconds;
		}
		public void Subtract(int seconds) {
			if (seconds < 0) throw new Exception("Invalid seconds parameter.");
			//	Value = Value - seconds;
			Value -= seconds;
		}
		#endregion
		#region operators
		public static Time operator +(Time obj, int seconds) {
			obj.Add(seconds); return obj;
		}
		public static Time operator -(Time obj, int seconds) {
			obj.Subtract(seconds); return obj;
		}
		public static int operator -(Time obj1, Time obj2) {
			return obj1.Value - obj2.Value;
		}
		public static bool operator ==(Time obj1, Time obj2) {
			return obj1.Value == obj2.Value;
		}
		public static bool operator !=(Time obj1, Time obj2) {
			return obj1.Value != obj2.Value;
		}
		public static bool operator ==(Time obj1, int value) {
			return obj1.Value == value;
		}
		public static bool operator !=(Time obj1, int value) {
			return obj1.Value == value;
		}
		#endregion
		#region conversion operators
		public static explicit operator int(Time obj) {
			return obj.Value;
		}
		public static explicit operator Time(int value) {
			Time obj = new Time(value);
			// Time obj = new Time();
			// obj.Value = value;
			return obj;
		}
		#endregion
		#region indexer property
		public short this[int index] {
			get {
				switch (index) {
					case 0: return hour;
					case 1: return minute;
					case 2: return second;
					default:
						throw new Exception(
							"Index out of range.");
				}
			}
			set {
				switch (index) {
					case 0: Hour = value; break;
					case 1: Minute = value; break;
					case 2: Second = value; break;
					default:
						throw new Exception(
							"Index out of range.");
				}
			}
		}
		public short this[char index] {
			get {
				if (index == 'h') return hour;
				if (index == 'm') return minute;
				if (index == 's') return second;
				throw new Exception(
					"Index out of range.");
			}
			set {
				if (index == 'h') Hour = value;
				else
				if (index == 'm') Minute = value;
				else
				if (index == 's') Second = value;
				else
					throw new Exception(
						"Index out of range.");
			}
		}
		#endregion
		#region standard methods
		public override string ToString() {
			return $"{hour:00}:{minute:00}:{second:00}";
		}
		public override int GetHashCode() {
			return Value;
		}
		public override bool Equals(object obj) {
			Time item = (Time)obj;
			if (item == this) return true;
			return Value == item.Value;
			//return hour == item.hour &&
			//	minute == item.minute &&
			//	second == item.second;
		}
		#endregion
		#region ICloneable
		object ICloneable.Clone() {
			return Clone();
		}
		#endregion
		#region ICloneable<Time>
		public Time Clone() {
			return new Time(hour, minute, second);
		}
		#endregion
		#region IComparable
		public int CompareTo(object obj) {
			Time item = (Time)obj;
			if (item == this) return 0;
			int value1 = this.Value;
			int value2 = item.Value;
			if (value1 < value2) return -1;
			if (value1 > value2) return +1;
			return 0;
		}
		#endregion
		#region IComparable<Time>
		public int CompareTo(Time obj) {
			if (obj == this) return 0;
			int value1 = this.Value;
			int value2 = obj.Value;
			if (value1 < value2) return -1;
			if (value1 > value2) return +1;
			return 0;
		}
		#endregion
		#region IComparable<int>
		public int CompareTo(int value) {
			int value1 = this.Value;
			if (value1 < value) return -1;
			if (value1 > value) return +1;
			return 0;
		}
		#endregion
	}
}
