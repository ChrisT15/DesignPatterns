using System;


namespace DesignPatterns
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Console.WriteLine ("Test: Abstrakte Frabrik");
			AbstractFactory abstractFactory = new AbstractFactory ();
			abstractFactory.test ();

			Console.WriteLine ("Test: Erbauer");
			Builder builder = new Builder();
			builder.Test ();

			Console.WriteLine ("Test: Beobachter");
			Observer observer = new Observer ();
			observer.Test ();

		}
	}
		
}
