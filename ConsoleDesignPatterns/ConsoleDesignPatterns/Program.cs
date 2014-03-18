using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	class Program
	{
		static void Main(string[] args) {
			
			#region Strategy Pattern

			//Strategy s = new PitBullDog();
			//Strategy s2 = new Doberman();

			//Context c = new Context(s);

			//if (Console.ReadLine() == "2") {
			//	c.Dog = s2;
			//}
			//else {
			//	c.Dog = s;
			//}
			//c.StrategyInterface();
			
			#endregion

			#region Observer

			//NewsPaper n = new NewsPaper();

			//n.Suscribe(new ValidateSuscribe(n, "Jose"));
			//n.Status = "Suscribe";
			//n.Notify();


			#endregion

			#region Decorator

			//ConcreteComponent c = new ConcreteComponent();

			//c.Description();

			#endregion

			#region Factory

			//ConcreteCreatorA creator = new ConcreteCreatorA();
			
			//creator.CreatePizza();

			//ConcreteCreatorB creators = new ConcreteCreatorB();
			//creators.Prepare();
			

			#endregion

			#region Abstract Factory

			//AbstractFactory factory = new ConcreteFactory1();

			//Client cliente = new Client(factory);
			//cliente.Run();


			#endregion

			#region Singleton

			//Singleton s = new Singleton();
			//Console.WriteLine(s.MySingleton.ToString());

			#endregion



			Console.ReadLine();
		}
	}
}
