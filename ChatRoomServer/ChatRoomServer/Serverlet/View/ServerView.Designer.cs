namespace ChatRoomServer
{
    partial class ServerView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.PanelBase = new System.Windows.Forms.TableLayoutPanel();
			this.ClickPanel = new System.Windows.Forms.TableLayoutPanel();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.MinimizeBtn = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.LoginAndPortPanel = new System.Windows.Forms.TableLayoutPanel();
			this.MaximizeBtn = new System.Windows.Forms.Button();
			this.PanelBase.SuspendLayout();
			this.ClickPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelBase
			// 
			this.PanelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PanelBase.ColumnCount = 2;
			this.PanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.PanelBase.Controls.Add(this.ClickPanel, 1, 0);
			this.PanelBase.Controls.Add(this.Title, 0, 0);
			this.PanelBase.Controls.Add(this.LoginAndPortPanel, 0, 1);
			this.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelBase.Location = new System.Drawing.Point(0, 0);
			this.PanelBase.Margin = new System.Windows.Forms.Padding(0);
			this.PanelBase.Name = "PanelBase";
			this.PanelBase.RowCount = 2;
			this.PanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.PanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PanelBase.Size = new System.Drawing.Size(476, 400);
			this.PanelBase.TabIndex = 0;
			// 
			// ClickPanel
			// 
			this.ClickPanel.AutoSize = true;
			this.ClickPanel.ColumnCount = 3;
			this.ClickPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ClickPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ClickPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ClickPanel.Controls.Add(this.CloseBtn, 2, 0);
			this.ClickPanel.Controls.Add(this.MaximizeBtn, 1, 0);
			this.ClickPanel.Controls.Add(this.MinimizeBtn, 0, 0);
			this.ClickPanel.Location = new System.Drawing.Point(336, 0);
			this.ClickPanel.Margin = new System.Windows.Forms.Padding(0);
			this.ClickPanel.Name = "ClickPanel";
			this.ClickPanel.RowCount = 1;
			this.ClickPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ClickPanel.Size = new System.Drawing.Size(135, 29);
			this.ClickPanel.TabIndex = 0;
			// 
			// CloseBtn
			// 
			this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseBtn.Location = new System.Drawing.Point(90, 0);
			this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(45, 29);
			this.CloseBtn.TabIndex = 2;
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// MinimizeBtn
			// 
			this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.MinimizeBtn.Location = new System.Drawing.Point(0, 0);
			this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.MinimizeBtn.Name = "MinimizeBtn";
			this.MinimizeBtn.Size = new System.Drawing.Size(45, 29);
			this.MinimizeBtn.TabIndex = 0;
			this.MinimizeBtn.UseVisualStyleBackColor = true;
			this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Title.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.Title.Location = new System.Drawing.Point(0, 12);
			this.Title.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
			this.Title.Name = "Title";
			this.Title.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.Title.Size = new System.Drawing.Size(73, 25);
			this.Title.TabIndex = 1;
			this.Title.Text = "服务端";
			this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LoginAndPortPanel
			// 
			this.LoginAndPortPanel.ColumnCount = 2;
			this.PanelBase.SetColumnSpan(this.LoginAndPortPanel, 2);
			this.LoginAndPortPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LoginAndPortPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LoginAndPortPanel.Location = new System.Drawing.Point(3, 49);
			this.LoginAndPortPanel.Name = "LoginAndPortPanel";
			this.LoginAndPortPanel.RowCount = 4;
			this.LoginAndPortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LoginAndPortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LoginAndPortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LoginAndPortPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LoginAndPortPanel.Size = new System.Drawing.Size(470, 348);
			this.LoginAndPortPanel.TabIndex = 4;
			// 
			// MaximizeBtn
			// 
			this.MaximizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MaximizeBtn.Location = new System.Drawing.Point(45, 0);
			this.MaximizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.MaximizeBtn.Name = "MaximizeBtn";
			this.MaximizeBtn.Size = new System.Drawing.Size(45, 29);
			this.MaximizeBtn.TabIndex = 1;
			this.MaximizeBtn.UseVisualStyleBackColor = true;
			this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
			// 
			// ServerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 400);
			this.Controls.Add(this.PanelBase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ServerView";
			this.Text = "ServerView";
			this.PanelBase.ResumeLayout(false);
			this.PanelBase.PerformLayout();
			this.ClickPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelBase;
        private System.Windows.Forms.TableLayoutPanel ClickPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TableLayoutPanel LoginAndPortPanel;
		private System.Windows.Forms.Button MaximizeBtn;
	}
}

