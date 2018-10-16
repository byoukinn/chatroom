using System;
using System.Windows.Forms;

namespace ChatRoom
{
	partial class ChatView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatView));
			this.MsgBox = new System.Windows.Forms.TableLayoutPanel();
			this.MsgInputPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ToolBar = new System.Windows.Forms.TableLayoutPanel();
			this.SendBtn = new System.Windows.Forms.Button();
			this.InputBox = new System.Windows.Forms.RichTextBox();
			this.BasePanel = new System.Windows.Forms.TableLayoutPanel();
			this.TitlePanel = new System.Windows.Forms.TableLayoutPanel();
			this.WindowsBtnPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Minimum = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.Maximize = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.MsgInputPanel.SuspendLayout();
			this.ToolBar.SuspendLayout();
			this.BasePanel.SuspendLayout();
			this.TitlePanel.SuspendLayout();
			this.WindowsBtnPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MsgBox
			// 
			this.MsgBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.MsgBox.ColumnCount = 3;
			this.MsgBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.06472F));
			this.MsgBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.93528F));
			this.MsgBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
			this.MsgBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MsgBox.Location = new System.Drawing.Point(0, 38);
			this.MsgBox.Margin = new System.Windows.Forms.Padding(0);
			this.MsgBox.Name = "MsgBox";
			this.MsgBox.RowCount = 3;
			this.MsgBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MsgBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MsgBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
			this.MsgBox.Size = new System.Drawing.Size(635, 411);
			this.MsgBox.TabIndex = 7;
			// 
			// MsgInputPanel
			// 
			this.MsgInputPanel.ColumnCount = 1;
			this.MsgInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MsgInputPanel.Controls.Add(this.ToolBar, 0, 1);
			this.MsgInputPanel.Controls.Add(this.InputBox, 0, 0);
			this.MsgInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MsgInputPanel.Location = new System.Drawing.Point(0, 449);
			this.MsgInputPanel.Margin = new System.Windows.Forms.Padding(0);
			this.MsgInputPanel.Name = "MsgInputPanel";
			this.MsgInputPanel.RowCount = 2;
			this.MsgInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.97298F));
			this.MsgInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.02703F));
			this.MsgInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.MsgInputPanel.Size = new System.Drawing.Size(635, 156);
			this.MsgInputPanel.TabIndex = 8;
			// 
			// ToolBar
			// 
			this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.ToolBar.ColumnCount = 2;
			this.ToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
			this.ToolBar.Controls.Add(this.SendBtn, 1, 0);
			this.ToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.ToolBar.Location = new System.Drawing.Point(0, 113);
			this.ToolBar.Margin = new System.Windows.Forms.Padding(0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.RowCount = 1;
			this.ToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ToolBar.Size = new System.Drawing.Size(635, 43);
			this.ToolBar.TabIndex = 2;
			// 
			// SendBtn
			// 
			this.SendBtn.AutoSize = true;
			this.SendBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.SendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendBtn.FlatAppearance.BorderSize = 0;
			this.SendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.SendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SendBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SendBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.SendBtn.Location = new System.Drawing.Point(572, 4);
			this.SendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SendBtn.Name = "SendBtn";
			this.SendBtn.Size = new System.Drawing.Size(60, 35);
			this.SendBtn.TabIndex = 0;
			this.SendBtn.Text = "发送";
			this.SendBtn.UseVisualStyleBackColor = false;
			// 
			// InputBox
			// 
			this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InputBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.InputBox.ForeColor = System.Drawing.SystemColors.Window;
			this.InputBox.Location = new System.Drawing.Point(17, 7);
			this.InputBox.Margin = new System.Windows.Forms.Padding(17, 7, 17, 7);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(601, 99);
			this.InputBox.TabIndex = 0;
			this.InputBox.Text = "";
			// 
			// BasePanel
			// 
			this.BasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.BasePanel.ColumnCount = 1;
			this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BasePanel.Controls.Add(this.TitlePanel, 0, 0);
			this.BasePanel.Controls.Add(this.MsgInputPanel, 0, 1);
			this.BasePanel.Controls.Add(this.MsgBox, 0, 1);
			this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BasePanel.Location = new System.Drawing.Point(0, 0);
			this.BasePanel.Margin = new System.Windows.Forms.Padding(0);
			this.BasePanel.Name = "BasePanel";
			this.BasePanel.RowCount = 2;
			this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.54167F));
			this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 411F));
			this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
			this.BasePanel.Size = new System.Drawing.Size(635, 605);
			this.BasePanel.TabIndex = 0;
			// 
			// TitlePanel
			// 
			this.TitlePanel.ColumnCount = 2;
			this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.TitlePanel.Controls.Add(this.WindowsBtnPanel, 1, 0);
			this.TitlePanel.Controls.Add(this.Title, 0, 0);
			this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitlePanel.Location = new System.Drawing.Point(0, 0);
			this.TitlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.TitlePanel.Name = "TitlePanel";
			this.TitlePanel.RowCount = 1;
			this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TitlePanel.Size = new System.Drawing.Size(635, 38);
			this.TitlePanel.TabIndex = 9;
			// 
			// WindowsBtnPanel
			// 
			this.WindowsBtnPanel.ColumnCount = 3;
			this.WindowsBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.WindowsBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.WindowsBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.WindowsBtnPanel.Controls.Add(this.Minimum, 0, 0);
			this.WindowsBtnPanel.Controls.Add(this.Exit, 2, 0);
			this.WindowsBtnPanel.Controls.Add(this.Maximize, 1, 0);
			this.WindowsBtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WindowsBtnPanel.Location = new System.Drawing.Point(510, 0);
			this.WindowsBtnPanel.Margin = new System.Windows.Forms.Padding(0);
			this.WindowsBtnPanel.Name = "WindowsBtnPanel";
			this.WindowsBtnPanel.RowCount = 1;
			this.WindowsBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.WindowsBtnPanel.Size = new System.Drawing.Size(125, 38);
			this.WindowsBtnPanel.TabIndex = 4;
			// 
			// Minimum
			// 
			this.Minimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.Minimum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimum.BackgroundImage")));
			this.Minimum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Minimum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Minimum.FlatAppearance.BorderSize = 0;
			this.Minimum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
			this.Minimum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Minimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimum.Location = new System.Drawing.Point(0, 0);
			this.Minimum.Margin = new System.Windows.Forms.Padding(0);
			this.Minimum.Name = "Minimum";
			this.Minimum.Size = new System.Drawing.Size(41, 38);
			this.Minimum.TabIndex = 3;
			this.Minimum.UseVisualStyleBackColor = false;
			this.Minimum.Click += new System.EventHandler(this.Chat_minimum_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
			this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
			this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Location = new System.Drawing.Point(82, 0);
			this.Exit.Margin = new System.Windows.Forms.Padding(0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(43, 38);
			this.Exit.TabIndex = 1;
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Chat_close_Click);
			// 
			// Maximize
			// 
			this.Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximize.BackgroundImage")));
			this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Maximize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Maximize.FlatAppearance.BorderSize = 0;
			this.Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
			this.Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Maximize.Location = new System.Drawing.Point(41, 0);
			this.Maximize.Margin = new System.Windows.Forms.Padding(0);
			this.Maximize.Name = "Maximize";
			this.Maximize.Size = new System.Drawing.Size(41, 38);
			this.Maximize.TabIndex = 2;
			this.Maximize.UseVisualStyleBackColor = false;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Title.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Title.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.Title.Location = new System.Drawing.Point(0, 0);
			this.Title.Margin = new System.Windows.Forms.Padding(0);
			this.Title.Name = "Title";
			this.Title.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.Title.Size = new System.Drawing.Size(510, 38);
			this.Title.TabIndex = 0;
			this.Title.Text = "聊天室";
			this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_By_MouseDown);
			// 
			// ChatView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 605);
			this.Controls.Add(this.BasePanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ChatView";
			this.MsgInputPanel.ResumeLayout(false);
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			this.BasePanel.ResumeLayout(false);
			this.TitlePanel.ResumeLayout(false);
			this.TitlePanel.PerformLayout();
			this.WindowsBtnPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MsgBox;
		private System.Windows.Forms.TableLayoutPanel MsgInputPanel;
		private System.Windows.Forms.TableLayoutPanel ToolBar;
		private System.Windows.Forms.Button SendBtn;
		private System.Windows.Forms.TableLayoutPanel BasePanel;
		private System.Windows.Forms.TableLayoutPanel TitlePanel;
		private System.Windows.Forms.TableLayoutPanel WindowsBtnPanel;
		private System.Windows.Forms.Button Minimum;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button Maximize;
		private System.Windows.Forms.Label Title;
		private RichTextBox InputBox;
	}
}