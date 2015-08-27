/*
 * Created by SharpDevelop.
 * User: Shuvankar
 * Date: 8/27/2015
 * Time: 8:48 AM
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroClip
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Hold the clipText.
		public string clipText = "";
		public string oldClipText = "";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			timerClip.Start();
			
		}
		void TimerClipTick(object sender, EventArgs e)
		{	
			clipText = Clipboard.GetText();
			if(clipText != "" && clipText != oldClipText)
			{
				listClips.Items.Add(clipText);
				oldClipText = clipText;
			}
		}
		void ListClipsMouseDoubleClick(object sender, MouseEventArgs e)
		{
			string clipItemText = listClips.SelectedItem.ToString();
			if (clipItemText != "")
			{
				Clipboard.SetText(clipItemText);
			}
	
		}
	}
}
