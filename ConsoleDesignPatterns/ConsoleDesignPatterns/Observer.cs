using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns
{
	/// <summary>
	/// Publisher and Suscriber : Readers
	/// </summary>
	abstract class Observer
	{
		public abstract void Update();
	}

	abstract class Readers
	{
		private List<Observer> _readers = new List<Observer>();
		public void Suscribe(Observer observer) {
			_readers.Add(observer);
		}

		public void Unsuscribe(Observer observer) {
			_readers.Remove(observer);
		}

		public void Notify() {
			foreach (Observer r in _readers) {
				r.Update();
			}
		}
	}

	class NewsPaper : Readers
	{
		private string _Name;
		private string _Status;
		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}
		public string Status {
			get { return _Status; }
			set { _Status = value; }
		}
	}
	class Magazine : Readers
	{
		private string _Name;
		private string _Status;
		public string Name {
			get { return _Name; }
			set { _Name = value; }
		}
		public string Status {
			get { return _Status; }
			set { _Status = value; }
		}
	}

	class ValidateSuscribe : Observer
	{
		private string _name;
		private string _observerStatus;
		private NewsPaper _suscriptor;

		public NewsPaper Suscriptor {
			get { return _suscriptor; }
			set { _suscriptor = value; }
		}

		public ValidateSuscribe(NewsPaper suscriptor, string name) {
			this._suscriptor = suscriptor;
			this._name = name;
		}

		public override void Update() {
			_observerStatus = _suscriptor.Name;
			Console.WriteLine("Suscriptor {0} is a new Suscribe in New York Times", _name);
		}
	}
}
