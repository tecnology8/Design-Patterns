using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// The Factory Pattern define una clase para crear un objeto, pero la SubClase decide cual Clase se va a Instanciar.
	///  Factory Method nos brinda una manera de encapsular las instancias de tipos concretos.
	///  
	/// Design Principle : The Dependency Inversion DI - Depende de una abstracion. No depende de una Clase Concreta.
	/// </summary>

	abstract class Product
	{
		public abstract void OrderPizza();
	}

	class ConcreteProductA : Product
	{
		public override void OrderPizza() {
			Console.WriteLine("Take an order");
		}
	}

	class ConcreteProductB : Product
	{
		public override void OrderPizza() {
			Console.WriteLine("Take an order");
		}
	}

	abstract class Creator
	{
		public abstract Product FactoryMethod();
		public abstract void CreatePizza();
		public abstract void Prepare();
		public abstract void Bake();
	}

	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod() {
			return new ConcreteProductA();
		}
		public override void CreatePizza() {
			Console.WriteLine("The Italian Pizza");
		}
		public override void Prepare() {
			Console.WriteLine("Prepare the Pizza");
		}

		public override void Bake() {
			Console.WriteLine("Baking the Pizza");
		}
	}

	class ConcreteCreatorB : Creator
	{
		public override void CreatePizza() {
			Console.WriteLine("A Cheese Pizza");
		}
		public override Product FactoryMethod() {
			return new ConcreteProductB();
		}

		public override void Prepare() {
			Console.WriteLine("Prepare the Pizza");
		}

		public override void Bake() {
			Console.WriteLine("Baking the Pizza");
		}
	}
}

