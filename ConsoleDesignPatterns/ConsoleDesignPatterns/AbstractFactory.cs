using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// The Abstract Factory Pattern : provee una interfaz para crear familias de relaciones o dependencias
	/// de objetos sin especificar sus clases concretas.
	/// </summary>
	abstract class AbstractFactory
	{
		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
	}

	class ConcreteFactory1 : AbstractFactory
	{
		public override AbstractProductA CreateProductA() {
			return new ProductA();
		}

		public override AbstractProductB CreateProductB() {
			return new ProductB();
		}
	}

	abstract class AbstractProductA
	{

	}

	abstract class AbstractProductB
	{
		public abstract void Interact(AbstractProductA a);
	}

	class ProductA : AbstractProductA
	{

	}

	class ProductB : AbstractProductB
	{
		public override void Interact(AbstractProductA a) {
			Console.WriteLine(this.GetType().Name +
				" interacts with " + a.GetType().Name);
		}
	}
	class Client
	{
		private AbstractProductA _abstractProductA;
		private AbstractProductB _abstractProductB;

		public Client(AbstractFactory factory) {
			_abstractProductA = factory.CreateProductA();
			_abstractProductB = factory.CreateProductB();
		}

		public void Run() {
			_abstractProductB.Interact(_abstractProductA);

		}
	}
}
