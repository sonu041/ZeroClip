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
			this.listClips = new System.Windows.Forms.ListBox();
			this.timerClip = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// listClips
			// 
			this.listClips.FormattingEnabled = true;
			this.listClips.Location = new System.Drawing.Point(0, 0);
			this.listClips.Name = "listClips";
			this.listClips.Size = new System.Drawing.Size(222, 329);
			this.listClips.TabIndex = 0;
			this.listClips.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListClipsMouseDoubleClick);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.Text = "ZeroClip";
			this.ResumeLayout(false);

		}
	}
}
