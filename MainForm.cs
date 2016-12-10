﻿/*
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
using System.Text;

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
				if(row.Cells[0].Value.ToString()=="firmi" || 
				   row.Cells[0].Value.ToString()=="masters" ||
				   row.Cells[0].Value.ToString()=="vurib")
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
			IsInTable=false;
			MySQL mysql = new MySQL();
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || row.Cells[0].Value.ToString()=="vurib" ||
					row.Cells[0].Value.ToString()=="masters" )
					row.Visible=false;
				}
			}
			catch(Exception ex){};
			ClearAllValues();
			}
		}
		
		void SetAllValues(){
			if(IsInTable){
				int rowid = MainDataGrid.CurrentRow.Index;
				NumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[1].Value.ToString();
				VirybNameTextBox.Text=MainDataGrid.Rows[rowid].Cells[0].Value.ToString();
				VuribModelTextBox.Text=MainDataGrid.Rows[rowid].Cells[2].Value.ToString();
				ClientNameTextBox.Text=MainDataGrid.Rows[rowid].Cells[3].Value.ToString();
				ClientAdressTextBox.Text=MainDataGrid.Rows[rowid].Cells[4].Value.ToString();
				ClientHomeNumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[5].Value.ToString();
				ClientWorkNumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[6].Value.ToString();
				ClientMobileNumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[7].Value.ToString();
				SkargiTextBox.Text=MainDataGrid.Rows[rowid].Cells[8].Value.ToString();
				MadeWorkRichTextBox.Text=MainDataGrid.Rows[rowid].Cells[9].Value.ToString();
				PrimitkiTextBox.Text=MainDataGrid.Rows[rowid].Cells[10].Value.ToString();
				GuaranteeComboBox.Text=MainDataGrid.Rows[rowid].Cells[11].Value.ToString();
				SerialNumberTextBox.Text=MainDataGrid.Rows[rowid].Cells[12].Value.ToString();
				ExtraInfoRichTextBox.Text=MainDataGrid.Rows[rowid].Cells[13].Value.ToString();
				MasterComboBox.Text=MainDataGrid.Rows[rowid].Cells[14].Value.ToString();
				ZapchastiCostTextBox.Text=MainDataGrid.Rows[rowid].Cells[15].Value.ToString();
				AllCostTextBox.Text=MainDataGrid.Rows[rowid].Cells[16].Value.ToString();
			}	
		}
		void ClearAllValues(){
			if(IsInTable==false){
				NumberTextBox.Text="";
				VirybNameTextBox.Text="";
				VuribModelTextBox.Text="";
				ClientNameTextBox.Text="";
				ClientAdressTextBox.Text="";
				ClientHomeNumberTextBox.Text="";
				ClientWorkNumberTextBox.Text="";
				ClientMobileNumberTextBox.Text="";
				SkargiTextBox.Text="";
				MadeWorkRichTextBox.Text="";
				PrimitkiTextBox.Text="";
				GuaranteeComboBox.Text="";
				SerialNumberTextBox.Text="";
				ExtraInfoRichTextBox.Text="";
				MasterComboBox.Text="";
				ZapchastiCostTextBox.Text="";
				AllCostTextBox.Text="";
			}
		}
		void MainDataGridSelectionChanged(object sender, EventArgs e)
		{
			if(IsInTable==true){
			SetAllValues();
			}
			if(IsInTable==false) ClearAllValues();
		}
		
		void SearchButtonClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			string findnum = NumberTextBox.Text;
			int rowcount = MainDataGrid.DisplayedRowCount(false);
			string[] tablenames = new string[rowcount];
			StringBuilder querry= new StringBuilder();
			querry.Append("select * from( (");
			for (int i = 0; i < rowcount; i++) {
				string str = MainDataGrid.Rows[i].Cells[0].Value.ToString();
				if(str!="firmi" && str!="masters" && str!="vurib")
				tablenames[i]=str;
			}
			for (int i = 0; i < rowcount; i++) {
				if(tablenames[i]!="vurib" && tablenames[i]!="masters" && tablenames[i]!="firmi"){
					if(i < rowcount-1)
						querry.Append("select ViribName,virib_id,ViribModel," +
"VlasnikName, VlasnikAdress, VlasnikHomeNumber," +
"VlasnikWorkNumber, VlasnikMobileNumber," +
"Skargi, VikonanaRobota, Primitki," +
"Guarantee, SerialNumber, ExtraVidomosti, " +
"MasterName, ZapchastiCost, TotalCost as virib_id"+i+" from "+tablenames[i]+")");
					if(i<rowcount-2) querry.Append( " union all ( ");
				}
			}
			querry.Append(") as t where virib_id="+findnum+";");
			MainDataGrid.DataSource=mysql.exWithResult(querry.ToString());
			IsInTable=true;
			//MadeWorkRichTextBox.Text=querry.ToString();
			}
			//SetAllValues();
		
	
	}
}
