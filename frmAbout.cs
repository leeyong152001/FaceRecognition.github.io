/*
 * Created by SharpDevelop.
 * User: Janphil Garay
 * Date: 16/02/2012
 * Time: 1:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaceRecognition
{
	/// <summary>
	/// Description of frmAbout.
	/// </summary>
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
		
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
