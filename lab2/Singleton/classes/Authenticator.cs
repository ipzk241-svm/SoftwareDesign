using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.classes
{
	internal sealed class Authenticator
	{

		private static Authenticator _instance;
		private static readonly object _lock = new object();
		private Authenticator() { }

		public static Authenticator GetInstance()
		{
			if (_instance == null)
			{
				lock (_lock)
				{
					_instance ??= new Authenticator();
				}
			}
			return _instance;
		}

		public void Authenticate(string username)
		{
			Console.WriteLine($"Аутентифікація користувача: {username} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
		}
	}
}
