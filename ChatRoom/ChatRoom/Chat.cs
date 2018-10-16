using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChatRoom
{
	class Chat : MVC.ApplicationBase<Chat>
	{

		private void InitializeChat()
		{
			RegisterController(Consts.E_Start, typeof(StartHandle));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SendEvent(Consts.E_Start);
		}

		public void ShowView(object View)
		{
			Application.Run((MVC.View)View);
		}

		public void Start()
		{
			InitializeChat();

			

		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Chat.Instance.Start();
		}
	}
}
