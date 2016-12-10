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
			mysql.connect("localhost","root","1","zverev_kursova_obd");
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			MasterDataGridView.DataSource=mysql.exWithResult(@"select master_name from masters");
			try{
			foreach(DataGridViewRow row in MasterDataGridView.Rows){ 
				MasterComboBox.Items.Add(row.Cells[0].Value.ToString());
			
				}
			}
			catch(Exception ex){ MessageBox.Show(ex.Message);}
			FirmiDataGridView.DataSource=mysql.exWithResult(@"select firm_name from firmi");
			try{
			foreach(DataGridViewRow row in FirmiDataGridView.Rows){ 
				GuaranteeComboBox.Items.Add(row.Cells[0].Value.ToString());
				}
			}
			catch(Exception ex){ MessageBox.Show(ex.Message);}
						MainDataGrid.CurrentCell=null;
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || row.Cells[0].Value.ToString()=="masters") 
					row.Visible=false;
				}
			}
			catch(Exception ex){};
			
		}
		
		void MainDataGridCellClick(object sender, DataGridViewCellEventArgs e)
		{
			MySQL mysql = new MySQL();
			string str= MainDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+str+";");
		}
		
		void SettingsButtonClick(object sender, EventArgs e)
		{
			SettingsForm sf = new SettingsForm();
			sf.Show();
		}
	}
}
