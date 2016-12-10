/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10.12.2016
 * Time: 9:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zverev_Kursova_OBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			mysql.connect("localhost","root","1","lab4");
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
		}
		
		void MainDataGridCellClick(object sender, DataGridViewCellEventArgs e)
		{
			MySQL mysql = new MySQL();
			//int rowid=MainDataGrid.CurrentRow.Index;
			//string str= MainDataGrid.Rows[rowid].Cells[0].Value.ToString();
			string str= MainDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+str+";");
		}
	}
}
