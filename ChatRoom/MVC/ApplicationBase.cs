using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC
{
	public abstract class ApplicationBase<T> : Singleton<T>
		where T : new()
	{
		protected void RegisterController(string eventName, Type controllerType)
		{
			MVC.RegisterController(eventName, controllerType);
		}

		protected void SendEvent(string eventName, object data = null)
		{
			MVC.SendEvent(eventName, data);
		}
	}
}
