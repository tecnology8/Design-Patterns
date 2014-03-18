using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// Dog Example
	/// </summary>
	abstract class Strategy
	{
		public abstract void Speak();
		public abstract void Walk();
	}

	class PitBullDog : Strategy /*IStrategy*/
	{
		public override void Speak() {
			Console.WriteLine("Hello My Name's Blacky");
		}
		public override void Walk() {
			Console.WriteLine("I Like Walk on the Street");
		}
	}
	class Doberman : Strategy
	{
		public override void Speak() {
			Console.WriteLine("Hello My Name's Stuart");
		}

		public override void Walk() {
			Console.WriteLine("I'm Love Walk on the Park");
		}
	}
	class Context
	{
		private Strategy _dog;
		public Context(Strategy dog) {
			this._dog = dog;
		}
		public void StrategyInterface() {
			_dog.Speak();
			_dog.Walk();
		}
	}
}