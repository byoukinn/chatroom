using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatRoomServer
{
	class StartController : MVC.Controller
	{
		public override void Execute(object data)
		{
			RegisterView(new ServerView());

			Server.Instance.ServerView(GetView<ServerView>());
		}
	}
}
