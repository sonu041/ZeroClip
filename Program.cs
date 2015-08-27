/*
 * Created by SharpDevelop.
 * User: Shuvankar
 * Date: 8/27/2015
 * Time: 8:48 AM
 * 
 */
using System;
using System.Windows.Forms;

namespace ZeroClip
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
