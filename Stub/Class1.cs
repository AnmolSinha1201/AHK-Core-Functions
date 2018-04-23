using System;
using static AHKCore.Nodes;
using static AHKCore.IndexedNodesFragment.Variables;

namespace AHKCore
{
	public class Functions
	{
		public static BaseAHKNode Test()
		{
			Console.WriteLine("FUNCTIONS LOADED");
			return null;
		}

		public static BaseAHKNode Test2(BaseAHKNode text)
		{
			return text;
		}

		public static BaseAHKNode Test3(BaseAHKNode text)
		{
			return new VariableValue() {Value = new SomeClass(text.extraInfo.ToString())};
		}

		public class Inner
		{
			public static BaseAHKNode Test()
			{
				Console.WriteLine("INNER CLASS");
				return null;
			}

			public static BaseAHKNode Test2(BaseAHKNode num1, BaseAHKNode num2)
			{
				return new VariableValue(){Value =  
				(int)((VariableValue)num1).Value + (int)((VariableValue)num2).Value};
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

		public BaseAHKNode GetText()
		{
			return new VariableValue() {Value = this.text};
		}
	}
}
