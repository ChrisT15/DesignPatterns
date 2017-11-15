using System;

namespace DesignPatterns
{
	public class AbstractFactory
	{
		

		public abstract class AbstrakteFabrik
		{
			public abstract AbstraktesProduktA ErzeugeProduktA();
			public abstract AbstraktesProduktB ErzeugeProduktB();
		}

		public class KonkreteFabrik1 : AbstrakteFabrik
		{
			public override AbstraktesProduktA ErzeugeProduktA()
			{
				return new KonkretesProduktA1();
			}

			public override AbstraktesProduktB ErzeugeProduktB()
			{
				return new KonkretesProduktB1();
			}
		}

		public class KonkreteFabrik2 : AbstrakteFabrik
		{
			public override AbstraktesProduktA ErzeugeProduktA()
			{
				return new KonkretesProduktA2 ();
			}

			public override AbstraktesProduktB ErzeugeProduktB()
			{
				return new KonkretesProduktB2 ();
			}
		}

		public abstract class AbstraktesProduktA
		{
			public abstract void ProduktErstellen();
		}

		public class KonkretesProduktA1 : AbstraktesProduktA
		{
			public override void ProduktErstellen ()
			{
				Console.WriteLine ("KonkretesProduktA1 erstellt");
			}
		}

		public class KonkretesProduktA2 : AbstraktesProduktA
		{
			public override void ProduktErstellen()
			{
				Console.WriteLine ("KonkretesProduktA2 erstellt");
			}
		}

		public abstract class AbstraktesProduktB
		{
			public abstract void ProduktErstellen();
		}

		public class KonkretesProduktB1 : AbstraktesProduktB
		{
			public override void ProduktErstellen()
			{
				Console.WriteLine ("KonkretesProduktB1 erstellt");
			}
		}

		public class KonkretesProduktB2: AbstraktesProduktB
		{
			public override void ProduktErstellen()
			{
				Console.WriteLine ("KonkretesProduktB2 erstellt");
			}
		}

		public class Kunde
		{
			private AbstraktesProduktA produktA;
			private AbstraktesProduktB produktB;

			public Kunde(AbstrakteFabrik fabrik)
			{
				produktA = fabrik.ErzeugeProduktA ();
				produktB = fabrik.ErzeugeProduktB ();
			}

			public void ProduktErstellen()
			{
				produktA.ProduktErstellen();
				produktB.ProduktErstellen();
			}
		}

		public void test()
		{

			AbstrakteFabrik fabrik1 = new KonkreteFabrik1 ();
			AbstrakteFabrik fabrik2 = new KonkreteFabrik2 ();
			Kunde kunde1 = new Kunde (fabrik1);
			Kunde kunde2 = new Kunde (fabrik2);
			Console.WriteLine ("Kunde1: ");
			kunde1.ProduktErstellen ();
			Console.WriteLine ("Kunde2: ");
			kunde2.ProduktErstellen ();
		}
	}
}

