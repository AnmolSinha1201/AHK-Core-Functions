using System;
using static AHKCore.Nodes;
using static AHKCore.IndexedNodesFragment.Variables;

namespace AHKCore
{
	public class Functions
	{
		public static object Test()
		{
			Console.WriteLine("FUNCTIONS LOADED");
			return null;
		}

		public static object Test2(object text)
		{
			return text;
		}

		public static object Test3(object text)
		{
			return new SomeClass(text.ToString());
		}

		public static object Test4(ref object var) //variable by ref test
		{
			var = "123";
			return null;
		}

		public class Inner
		{
			public static object Test()
			{
				Console.WriteLine("INNER CLASS");
				return null;
			}

			public static object Test2(object num1, object num2)
			{
				return (dynamic)num1 + num2;
			}
		}
	}

	public class SomeClass
	{
		string text;
		public SomeClass(string text)
		{
			this.text = text;
		}

		public object GetText()
		{
			return this.text;
		}
	}
}
