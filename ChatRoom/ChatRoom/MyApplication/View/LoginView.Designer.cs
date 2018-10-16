namespace ChatRoom
{
	partial class LoginView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
			this.login_base = new System.Windows.Forms.TableLayoutPanel();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.signup_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.user_name = new System.Windows.Forms.Label();
			this.user_password = new System.Windows.Forms.Label();
			this.user_name_input = new System.Windows.Forms.TextBox();
			this.login_btn = new System.Windows.Forms.Button();
			this.user_password_input = new System.Windows.Forms.TextBox();
			this.login_base.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// login_base
			// 
			this.login_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.login_base.ColumnCount = 2;
			this.login_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.login_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
			this.login_base.Controls.Add(this.CancelBtn, 0, 5);
			this.login_base.Controls.Add(this.signup_btn, 0, 4);
			this.login_base.Controls.Add(this.pictureBox1, 0, 0);
			this.login_base.Controls.Add(this.user_name, 0, 1);
			this.login_base.Controls.Add(this.user_password, 0, 2);
			this.login_base.Controls.Add(this.user_name_input, 1, 1);
			this.login_base.Controls.Add(this.login_btn, 0, 3);
			this.login_base.Controls.Add(this.user_password_input, 1, 2);
			this.login_base.Dock = System.Windows.Forms.DockStyle.Fill;
			this.login_base.Location = new System.Drawing.Point(0, 0);
			this.login_base.Margin = new System.Windows.Forms.Padding(0);
			this.login_base.Name = "login_base";
			this.login_base.Padding = new System.Windows.Forms.Padding(60, 56, 60, 56);
			this.login_base.RowCount = 6;
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.05376F));
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.94624F));
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
			this.login_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
			this.login_base.Size = new System.Drawing.Size(440, 562);
			this.login_base.TabIndex = 0;
			// 
			// CancelBtn
			// 
			this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelBtn.BackColor = System.Drawing.Color.White;
			this.login_base.SetColumnSpan(this.CancelBtn, 2);
			this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CancelBtn.FlatAppearance.BorderSize = 0;
			this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelBtn.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
			this.CancelBtn.ForeColor = System.Drawing.Color.DarkGray;
			this.CancelBtn.Location = new System.Drawing.Point(67, 462);
			this.CancelBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(306, 38);
			this.CancelBtn.TabIndex = 7;
			this.CancelBtn.Text = "取      消";
			this.CancelBtn.UseVisualStyleBackColor = false;
			this.CancelBtn.Click += new System.EventHandler(this.Cancel_btn_Click);
			// 
			// signup_btn
			// 
			this.signup_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.signup_btn.BackColor = System.Drawing.Color.CornflowerBlue;
			this.login_base.SetColumnSpan(this.signup_btn, 2);
			this.signup_btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.signup_btn.FlatAppearance.BorderSize = 0;
			this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signup_btn.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
			this.signup_btn.ForeColor = System.Drawing.Color.White;
			this.signup_btn.Location = new System.Drawing.Point(67, 411);
			this.signup_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.signup_btn.Name = "signup_btn";
			this.signup_btn.Size = new System.Drawing.Size(306, 39);
			this.signup_btn.TabIndex = 6;
			this.signup_btn.Text = "注      册";
			this.signup_btn.UseVisualStyleBackColor = false;
			this.signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
			// 
			// pictureBox1
			// 
			this.login_base.SetColumnSpan(this.pictureBox1, 2);
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(60, 56);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(320, 152);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// user_name
			// 
			this.user_name.AutoSize = true;
			this.user_name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.user_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_name.ForeColor = System.Drawing.Color.White;
			this.user_name.Location = new System.Drawing.Point(64, 208);
			this.user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.user_name.Name = "user_name";
			this.user_name.Size = new System.Drawing.Size(77, 81);
			this.user_name.TabIndex = 1;
			this.user_name.Text = "用户名";
			this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// user_password
			// 
			this.user_password.AutoSize = true;
			this.user_password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.user_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_password.ForeColor = System.Drawing.Color.White;
			this.user_password.Location = new System.Drawing.Point(64, 289);
			this.user_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.user_password.Name = "user_password";
			this.user_password.Size = new System.Drawing.Size(77, 64);
			this.user_password.TabIndex = 2;
			this.user_password.Text = "密码";
			this.user_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// user_name_input
			// 
			this.user_name_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.user_name_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.user_name_input.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_name_input.Location = new System.Drawing.Point(145, 237);
			this.user_name_input.Margin = new System.Windows.Forms.Padding(0);
			this.user_name_input.MinimumSize = new System.Drawing.Size(220, 26);
			this.user_name_input.Name = "user_name_input";
			this.user_name_input.Size = new System.Drawing.Size(235, 26);
			this.user_name_input.TabIndex = 3;
			this.user_name_input.WordWrap = false;
			// 
			// login_btn
			// 
			this.login_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.login_btn.BackColor = System.Drawing.Color.CornflowerBlue;
			this.login_base.SetColumnSpan(this.login_btn, 2);
			this.login_btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.login_btn.FlatAppearance.BorderSize = 0;
			this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_btn.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
			this.login_btn.ForeColor = System.Drawing.Color.White;
			this.login_btn.Location = new System.Drawing.Point(67, 359);
			this.login_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(306, 40);
			this.login_btn.TabIndex = 5;
			this.login_btn.Text = "登      录";
			this.login_btn.UseVisualStyleBackColor = false;
			this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
			// 
			// user_password_input
			// 
			this.user_password_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.user_password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.user_password_input.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_password_input.Location = new System.Drawing.Point(145, 309);
			this.user_password_input.Margin = new System.Windows.Forms.Padding(0);
			this.user_password_input.MinimumSize = new System.Drawing.Size(220, 26);
			this.user_password_input.Name = "user_password_input";
			this.user_password_input.PasswordChar = '*';
			this.user_password_input.Size = new System.Drawing.Size(235, 26);
			this.user_password_input.TabIndex = 4;
			this.user_password_input.WordWrap = false;
			// 
			// LoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 562);
			this.Controls.Add(this.login_base);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "LoginView";
			this.Text = "LoginView";
			this.login_base.ResumeLayout(false);
			this.login_base.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel login_base;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label user_name;
		private System.Windows.Forms.Label user_password;
		private System.Windows.Forms.TextBox user_name_input;
		private System.Windows.Forms.TextBox user_password_input;
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.Button signup_btn;
		private System.Windows.Forms.Button CancelBtn;
	}
}