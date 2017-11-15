using System;
using System.Collections.Generic;

namespace DesignPatterns
{
	class Observer
	{
		public abstract class Beobachter
		{
			public abstract void Aktualisieren();
		}

		public class KonkreterBeobachter : Beobachter
		{
			private string name;
			private string beobachterZustand;
			private KonkretesSubjekt konkretesSubjekt;

			public override void Aktualisieren ()
			{
				beobachterZustand = konkretesSubjekt.SubjektZustand;
				Console.WriteLine ("Neuer Zustand des Beobachters {0} ist {1}",name,beobachterZustand);

			}

			public KonkreterBeobachter(KonkretesSubjekt konkretesSubjekt, string name)
			{
				this.konkretesSubjekt = konkretesSubjekt;
				this.name = name;
			}

			public KonkretesSubjekt KonkretesSubjekt
			{
				get{ return konkretesSubjekt;}
				set{ konkretesSubjekt = value;} 
			}

			public string Name
			{
				get{ return name; }
				set{ name = value;}
			}


		}
	

		public class Subjekt
		{
			private List<Beobachter> beobachter_l = new List<Beobachter>();

			public void Registrieren(Beobachter beobachter)
			{
				beobachter_l.Add (beobachter);
			}

			public void Entfernen(Beobachter beobachter)
			{
				beobachter_l.Remove (beobachter);
			}

			public void Benachrichtigen()
			{
				foreach (Beobachter beobachter in beobachter_l) 
				{
					beobachter.Aktualisieren ();
				}
			}
		}

		public class KonkretesSubjekt : Subjekt
		{
			private string subjektZustand;

			public string SubjektZustand
			{
				get { return subjektZustand;}
				set { subjektZustand = value;}
			}
		}

		public void Test()
		{
			KonkretesSubjekt konkretesSubjekt = new KonkretesSubjekt ();

			konkretesSubjekt.Registrieren (new KonkreterBeobachter(konkretesSubjekt,"Beobachter1"));
			konkretesSubjekt.Registrieren (new KonkreterBeobachter(konkretesSubjekt,"Beobacher2"));
			konkretesSubjekt.Registrieren (new KonkreterBeobachter(konkretesSubjekt,"Beobachter3"));

			konkretesSubjekt.SubjektZustand = "neuer Zustand";
			konkretesSubjekt.Benachrichtigen ();
		}


	}
}

