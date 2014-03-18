using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// The Decorator Pattern
	/// agrega responsabilidad adicional a un objeto dinamicamente.
	/// Los Decoradores proveen una alternativa flexible a las SubClases extendiendo su Funcionalidad.
	/// </summary>
	///  The Design Principle Open Close : Classes should be open for extension but closed for modification.


	abstract class Component
	{
		public abstract void Description();
		public abstract double Cost();
	}
	class ConcreteComponent : Component
	{
		public override void Description() {
			Console.WriteLine("Coffee Express");
		}

		public override double Cost() {
			return 20.9;
		}
	}

	abstract class Decorator : Component
	{
		protected Component component;

		public void SetComponent(Component component) 
		{
			this.component = component;
		}

		public override void Description() {
			if (component != null ) {
				component.Description();
			}
		}
	}

	abstract class ConcreteDecoratorA : Decorator
	{
		public override void Description() {
			Console.WriteLine("ConcreteDecoratorA.Description()");
		}
	}

	abstract class ConcreteDecoratorB : Decorator
	{
		public override void Description() {
			base.Description();
			AddedBehavior();
			Console.WriteLine("ConcreteDecoratorB.Description()");
		}

		void AddedBehavior() { }
	}
}
