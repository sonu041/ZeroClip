/*
 * Created by SharpDevelop.
 * User: Shuvankar
 * Date: 8/27/2015
 * Time: 8:48 AM
 *
 */
namespace ZeroClip
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listClips;
		private System.Windows.Forms.Timer timerClip;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripClip;
		private System.Windows.Forms.ToolStripMenuItem showTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listClips = new System.Windows.Forms.ListBox();
			this.contextMenuStripClip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerClip = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStripClip.SuspendLayout();
			this.SuspendLayout();
			// 
			// listClips
			// 
			this.listClips.ContextMenuStrip = this.contextMenuStripClip;
			this.listClips.FormattingEnabled = true;
			this.listClips.Location = new System.Drawing.Point(0, 0);
			this.listClips.Name = "listClips";
			this.listClips.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listClips.Size = new System.Drawing.Size(222, 316);
			this.listClips.TabIndex = 0;
			this.listClips.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListClipsKeyDown);
			this.listClips.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListClipsMouseDoubleClick);
			// 
			// contextMenuStripClip
			// 
			this.contextMenuStripClip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.showTextToolStripMenuItem,
			this.aboutToolStripMenuItem});
			this.contextMenuStripClip.Name = "contextMenuStripClip";
			this.contextMenuStripClip.Size = new System.Drawing.Size(126, 48);
			// 
			// showTextToolStripMenuItem
			// 
			this.showTextToolStripMenuItem.Name = "showTextToolStripMenuItem";
			this.showTextToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.showTextToolStripMenuItem.Text = "ShowText";
			this.showTextToolStripMenuItem.Click += new System.EventHandler(this.ShowTextToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// timerClip
			// 
			this.timerClip.Interval = 1000;
			this.timerClip.Tick += new System.EventHandler(this.TimerClipTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(221, 319);
			this.Controls.Add(this.listClips);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.Text = "ZeroClip";
			this.contextMenuStripClip.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
