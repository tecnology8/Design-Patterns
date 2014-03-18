using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	interface IStrategy
	{
		void Speak();
		void Swim();
		void Walk();
		void Run();
		void Display();
	}
}
