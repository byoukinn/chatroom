using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC
{
	public partial class View : Form
	{

		public List<string> AttentionEvents = new List<string>();

		public View()
		{
			InitializeComponent();
		}

		public virtual void RegisterEvents()
		{

		}

		public virtual void HandleEvent(string eventName, object data)
		{

		}

		protected T GetModel<T>()
		where T : Model
		{
			return MVC.GetModel<T>() as T;
		}

		protected void SendEvent(string eventName, object data = null)
		{
			MVC.SendEvent(eventName, data);
		}

	}
}
