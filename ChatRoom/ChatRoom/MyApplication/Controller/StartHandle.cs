using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatRoom
{
	public class StartHandle : MVC.Controller
	{
		public override void Execute(object data)
		{
			//  TODO: 注册控制器
			RegisterController(Consts.E_Login, typeof(LoginHandle));
			RegisterView(new LoginView());

			Chat.Instance.ShowView(GetView<LoginView>());
		}

		

	}
}
