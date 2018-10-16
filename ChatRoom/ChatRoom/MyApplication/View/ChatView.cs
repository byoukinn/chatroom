using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChatRoom
{
	public partial class ChatView : MVC.View
	{
		public ChatView()
		{
			InitializeComponent();
		}

		private void Chat_close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Chat_minimum_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		

		public new string Name => throw new NotImplementedException();

		/// <summary>
		/// 鼠标按下
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveWindow_By_MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
			ReleaseCapture();
			//发送消息 让系统误以为在标题栏上按下鼠标
			SendMessage((IntPtr)this.Handle, Consts.VM_NCLBUTTONDOWN, Consts.HTCAPTION, 0);
		}

		public override void HandleEvent(string eventName, object data)
		{
			throw new NotImplementedException();
		}
	}
}
