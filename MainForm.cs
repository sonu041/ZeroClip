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
		
		/* On timer tick copy the text from clipboard and show in list. */
		void TimerClipTick(object sender, EventArgs e)
		{	
			clipText = Clipboard.GetText();
			if(clipText != "" && clipText != oldClipText)
			{
				//Remove duplicate clipText
                if (listClips.Items.Contains(clipText))
                {
                    listClips.Items.Remove(clipText);
                }
                
				listClips.Items.Insert(0, clipText);
				oldClipText = clipText;
			}
		}
		
		/* Double click on item to copy in clipboard. */
		void ListClipsMouseDoubleClick(object sender, MouseEventArgs e)
		{
			string clipItemText = listClips.SelectedItem.ToString();
			if (clipItemText != "")
			{
				Clipboard.SetText(clipItemText);
			}
		}
		
		/* Delete the item from the list. */
		void ListClipsKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				for(int i=listClips.SelectedIndices.Count - 1; i>=0; i--)
				{
					listClips.Items.RemoveAt(listClips.SelectedIndices[i]);
				}
			}
		}
	}
}
