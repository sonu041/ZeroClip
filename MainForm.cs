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
			CopyItem();
		}
		
		/* Handle KeyPress Event. */
		void ListClipsKeyDown(object sender, KeyEventArgs e)
		{
			// Press Delete - Delete the item from the list.
			if(e.KeyCode == Keys.Delete)
			{
				DeleteItem(e);
			}
			
			// Press Enter - Show full text.
			if(e.KeyCode == Keys.Enter)
			{
				ShowFullText();
			}
			
			// Press C - Copy item.
			if(e.KeyCode == Keys.C)
			{
				CopyItem();
			}
			
		}
		void ShowTextToolStripMenuItemClick(object sender, EventArgs e)
		{
			ShowFullText();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show ("ZeroClip - Developed by Shuvankar Sarkar (shuvankar.com)", "Follow @sonu041 in twitter",
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	
		}
		
		//TODO: Move the libraries region to separate file.
		#region Libraries
		
		/* Delete the item */
		void DeleteItem(KeyEventArgs e)
		{
			for(int i=listClips.SelectedIndices.Count - 1; i>=0; i--)
			{
				listClips.Items.RemoveAt(listClips.SelectedIndices[i]);
			}
		}
		
		/* Copy the item to clipboard */
		void CopyItem()
		{
			string clipItemText = listClips.SelectedItem.ToString();
			if (clipItemText != "")
			{
				Clipboard.SetText(clipItemText);
			}
		}
		
		/* Show full text */
		void ShowFullText()
		{
			if (listClips.SelectedIndex != -1)
			{
				MessageBox.Show (listClips.SelectedItem.ToString(), "ZeroClip FullText",
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show ("Select an item first", "ZeroClip",
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		
		#endregion
		
	}
}
