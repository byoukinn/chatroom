using MVC;
using System;
using System.Windows.Forms;

namespace ChatRoom
{
	public partial class LoginView : MVC.View
	{
		public new string Name => Consts.V_LoginView;

		public LoginView()
		{
			InitializeComponent();
		}

		public override void RegisterEvents()
		{
			
		}

		public override void HandleEvent(string eventName, object data)
		{
			
		}

		private void Cancel_btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_btn_Click(object sender, EventArgs e)
		{
			// TODO: 让LoginHandle去完成
			string userName = user_name_input.Text;
			string userPassword = user_password_input.Text;
			if (userName == "admin" && userPassword == "123")
			{
				SendEvent(Consts.E_Login);
				ReplaceNextView();
			}
		}

		private void ReplaceNextView()
		{
			new System.Threading.Thread(() =>
			{
				Application.Run(MVC.MVC.GetView<ChatView>());
			}).Start();
			Application.ExitThread();
		}

		private void Signup_btn_Click(object sender, EventArgs e)
		{
			// TODO: 让SignUpHandle去完成

		}
	}
}
