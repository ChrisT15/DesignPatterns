using System;
using System.Collections.Generic;

namespace DesignPatterns
{
	public class Builder
	{
		public class Direktor
		{
			public void Konstruiere(Erbauer erbauer)
			{
				erbauer.ErbaueTeilA();
				erbauer.ErbaueTeilB();
			}
		}

		public abstract class Erbauer
		{
			public abstract void ErbaueTeilA();
			public abstract void ErbaueTeilB();
			public abstract Produkt ErhalteErgebnis();
		}


		public class KonkreterErbauer1 : Erbauer
		{
			private Produkt produkt = new Produkt();

			public override void ErbaueTeilA ()
			{
				produkt.Hinzufuegen ("TeilA1");
			}
			public override void ErbaueTeilB ()
			{
				produkt.Hinzufuegen ("TeilB1");
			}

			public override Produkt ErhalteErgebnis()
			{
				return produkt;
			}
		}

		public class KonkreterErbauer2 : Erbauer
		{
			private Produkt produkt = new Produkt();

			public override void ErbaueTeilA ()
			{
				produkt.Hinzufuegen ("TeilA2");
			}
			public override void ErbaueTeilB ()
			{
				produkt.Hinzufuegen ("TeilB2");
			}

			public override Produkt ErhalteErgebnis()
			{
				return produkt;
			}
		}


		public class Produkt
		{
			private List<string> teile = new List<string>();	

			public void Hinzufuegen(string teil)
			{
				teile.Add (teil);
			}

			public void Zeige()
			{
				Console.WriteLine ("Produktteile: ");
				foreach(string teil in teile)
				{
					Console.WriteLine (teil);
				}
			}
		}

		public void Test()
		{
			Direktor direktor = new Direktor ();

			Erbauer e1 = new KonkreterErbauer1();
			Erbauer e2 = new KonkreterErbauer2();

			direktor.Konstruiere (e1);
			Produkt p1 = e1.ErhalteErgebnis();
			p1.Zeige ();

			direktor.Konstruiere (e2);
			Produkt p2 = e2.ErhalteErgebnis();
			p2.Zeige ();

		}
	}
}

