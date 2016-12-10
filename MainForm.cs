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
		bool IsInTable=false;
		public MainForm()
		{
			InitializeComponent();
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
			if(!IsInTable){
			MySQL mysql = new MySQL();
			string str= MainDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+str+";");
			IsInTable=true;
			SetAllValues();
			}
		}
		
		void SettingsButtonClick(object sender, EventArgs e)
		{
			SettingsForm sf = new SettingsForm();
			sf.Show();
		}
		
		void BackPictureBoxClick(object sender, EventArgs e)
		{
			if(IsInTable){
			MySQL mysql = new MySQL();
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || row.Cells[0].Value.ToString()=="masters") 
					row.Visible=false;
				}
			}
			catch(Exception ex){};
			IsInTable=false;
			}
		}
		
		void SetAllValues(){
			if(IsInTable){
				int rowid = MainDataGrid.CurrentRow.Index;
				NumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[1].Value.ToString();
				VirybNameTextBox.Text=MainDataGrid.Rows[rowid].Cells[0].Value.ToString();
				VuribModelTextBox.Text=MainDataGrid.Rows[rowid].Cells[2].Value.ToString();
				ClientNameTextBox.Text=MainDataGrid.Rows[rowid].Cells[3].Value.ToString();
			}
		}
	}
}
