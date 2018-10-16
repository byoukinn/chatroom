using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChatRoomServer
{
    class Server : MVC.ApplicationBase<Server>
    {
		private void Start()
		{
			RegisterController(Consts.C_Start, typeof(StartController));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SendEvent(Consts.C_Start);
		}

		public void ServerView(object View)
		{
			Application.Run((MVC.View)View);
		}

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
			Server.Instance.Start();
        }
    }
}
