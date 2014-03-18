using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// The Singleton Pattern: Se asegura de que una clase tenga solo una Instancia, y provee un punto global de acceso hacia ella.
	/// </summary>
	class Singleton
	{
		private static Singleton Instance = null;

		public string MySingleton { get; set; }
		public Singleton() {
			MySingleton = "I am a Singleton";
		}

		public static Singleton GetInstance() {
			if (Instance == null) {
				Instance = new Singleton();
			}
			return Instance;
		}
	}
}
