using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatRoom
{
	class LoginHandle : MVC.Controller
	{
		

		public override void Execute(object data)
		{
			//  TODO: 注册视图
			RegisterView(new ChatView());

			

			
		}
	}
}
