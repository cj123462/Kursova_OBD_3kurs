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
		bool IsItExists=true;
		bool IsSearchModeOn=false;
		bool IsSelectedForKassa=false;
		bool IsSelectedMasterSalary=false;
		string ZakazName="";
		string CopyName="";
		string CopyHomePhoneNumber="";
		string CopyWorkPhoneNumber="";
		string CopyMobilePhoneNumber="";
		string CopyAdress="";
		//StringBuilder strBuild= new StringBuilder();
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			SearchFirmButton.Enabled=false;
			mysql.connect("localhost","root","1","zverev_kursova_obd");
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			SetDataGridValues();
			MasterDataGridView.DataSource=mysql.exWithResult(@"select master_name from masters");
			try{
			foreach(DataGridViewRow row in MasterDataGridView.Rows){ 
				MasterComboBox.Items.Add(row.Cells[0].Value.ToString());
			
				}
			}
			catch(Exception ex){}
			FirmiDataGridView.DataSource=mysql.exWithResult(@"select firm_name from firmi");
			try{
			foreach(DataGridViewRow row in FirmiDataGridView.Rows){ 
				GuaranteeComboBox.Items.Add(row.Cells[0].Value.ToString());
				}
			}
			catch(Exception ex){}
						MainDataGrid.CurrentCell=null;
						SetDataGridValues();
			this.KeyPreview=true;
			
		}
		
		void MainDataGridCellClick(object sender, DataGridViewCellEventArgs e)
		{
			ZakazName=MainDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
			PriyomButtom.Enabled=true;
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
			SetDataGridValues();
			}
			ClearAllValues();
			ReadyLabel.Visible=false;
		}
		
		void SetAllValues(){
			MySQL mysql = new MySQL();
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
				try{
				if(MainDataGrid.Rows[rowid].Cells[17].Value.ToString()!=""){
				string vidano=MainDataGrid.Rows[rowid].Cells[17].Value.ToString();
				VidanoTextBox.Text=vidano.Substring(0,10);}
				} catch(Exception ex) {};
				DateTimeDataGridView.DataSource=mysql.exWithResult(@"select * from dates "+
				 "where virib_id="+Int32.Parse(NumberTextBox.Text)+";");
				string prijom = DateTimeDataGridView.Rows[0].Cells[1].Value.ToString();
				PrijomDateTextBox.Text=prijom.Substring(0,10);
				if(DateTimeDataGridView.Rows[0].Cells[2].Value.ToString()!=""){
				string info =DateTimeDataGridView.Rows[0].Cells[2].Value.ToString();
				ClientInformatedTextBox.Text=info.Substring(0,10);}
				if(DateTimeDataGridView.Rows[0].Cells[3].Value.ToString()!=""){
				string guar =DateTimeDataGridView.Rows[0].Cells[3].Value.ToString();
				GuaranteeExpireTextBox.Text=guar.Substring(0,10);
				}
				
				if(AllCostTextBox.Text!="0" && AllCostTextBox.Text!=""){ 
					VidachaButton.Enabled=true;
					ReadyLabel.Visible=true;
				}
				try{
				ExtraInfoDataGridView.DataSource=mysql.exWithResult(@"select * from
					extra_info where virib_id="+Int32.Parse(NumberTextBox.Text)
				     +";");
				TerminalTextBox.Text=ExtraInfoDataGridView.Rows[0].Cells[1].Value.ToString();
				AcumulatorTextBox.Text=ExtraInfoDataGridView.Rows[0].Cells[2].Value.ToString();
				ZP1TextBox.Text=ExtraInfoDataGridView.Rows[0].Cells[3].Value.ToString();
				ZP2TextBox.Text=ExtraInfoDataGridView.Rows[0].Cells[4].Value.ToString();
				if(ExtraInfoDataGridView.Rows[0].Cells[5].Value.ToString()=="1")
					GarTalonCheckBox.Checked=true;
				if(ExtraInfoDataGridView.Rows[0].Cells[6].Value.ToString()=="1")
					RemoteCheckBox.Checked=true;
				if(ExtraInfoDataGridView.Rows[0].Cells[7].Value.ToString()=="1")
					RemoteCheckBox.Checked=true;
				}
				catch(Exception ex){};
			}	
		}
		
		void ClearAllValues(){
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
				ClientInformatedTextBox.Text="";
				PrijomDateTextBox.Text="";
				VidanoTextBox.Text="";
				VidachaButton.Enabled=false;
				TerminalTextBox.Text="";
				AcumulatorTextBox.Text="";
				ZP1TextBox.Text="";
				ZP2TextBox.Text="";
				GarTalonCheckBox.Checked=false;
				RemoteCheckBox.Checked=false;
				RemoteCheckBox.Checked=false;
				GuaranteeExpireTextBox.Text="";
		}
		void MainDataGridSelectionChanged(object sender, EventArgs e)
		{
			if(IsInTable==true){
				ClearAllValues();
				SetAllValues();
				if(AllCostTextBox.Text=="0" || AllCostTextBox.Text==""){ 
					ReadyLabel.Visible=false;
					ClientInformatedTextBox.Text="";
				}
			}
			if(IsInTable==false) ClearAllValues();
			IsItExists=true;
			
		}
		
		void SearchButtonClick(object sender, EventArgs e)
		{
			IsInTable=false;
			ClearAllValues();
			MySQL mysql = new MySQL();
			mysql.exWithoutResult(@"start transaction;");
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			mysql.exWithoutResult(@"commit;");
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || 
				   row.Cells[0].Value.ToString()=="masters" ||
				   row.Cells[0].Value.ToString()=="vurib" ||
				   row.Cells[0].Value.ToString()=="dates" ||
				   row.Cells[0].Value.ToString()=="extra_info")
					row.Visible=false;
				}
			}
			catch(Exception ex){};
			
			IsSearchModeOn=true;
			SetColors(SystemColors.GradientActiveCaption);
			
		}
		
		void MainDataGridDoubleClick(object sender, EventArgs e)
		{
			if(!IsInTable){
			MySQL mysql = new MySQL();
			int rowindex = MainDataGrid.CurrentRow.Index;
			string str= MainDataGrid.Rows[rowindex].Cells[0].Value.ToString();
			mysql.exWithoutResult(@"start transaction;");
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+str+";");
			mysql.exWithoutResult(@"commit;");
			IsInTable=true;
			ClearAllValues();
			SetAllValues();
			SetDataGridValues();
			SearchFirmButton.Enabled=true;
			}
		}
		
		void PriyomButtomClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			mysql.exWithoutResult(@"start transaction;");
			mysql.exWithoutResult(@"insert into vurib (void) values('');");
			NumberDataGridView.DataSource=mysql.exWithResult(@"select last_insert_id()");
			mysql.exWithoutResult(@"commit;");
			NumberTextBox.Text=NumberDataGridView.Rows[0].Cells[0].Value.ToString();
			int num=Int32.Parse(NumberTextBox.Text);
			VirybNameTextBox.Text=ZakazName;
			IsItExists=false;
			DateTime myDateTime=DateTime.Now;
			PrijomDateTextBox.Text=myDateTime.ToString("dd-MM-yyyy");
			mysql.exWithResult(@"insert into dates (Virib_id,Priyom_date) values ("+
			 	                   num+",'"+myDateTime.Date.ToString("yyyyMMdd")+"')");
		}
		
		void OKButtonClick(object sender, EventArgs e)
		{
			if(IsSearchModeOn==false){
			MySQL mysql = new MySQL();
			int num=Int32.Parse(NumberTextBox.Text);
			int sn=0;
			if(SerialNumberTextBox.Text!="") sn=Int32.Parse(SerialNumberTextBox.Text);
			 string s1=VirybNameTextBox.Text;
			 string s2=VuribModelTextBox.Text;
			 string s3=ClientNameTextBox.Text;
			 string s4=ClientAdressTextBox.Text;
			 string s5=ClientHomeNumberTextBox.Text;
			 string s6=ClientWorkNumberTextBox.Text;
			 string s7=ClientMobileNumberTextBox.Text;
			 string s8=SkargiTextBox.Text;
			 string s9=MadeWorkRichTextBox.Text;
			 string s10=PrimitkiTextBox.Text;
			 string s11=GuaranteeComboBox.Text;
			 string s12=ExtraInfoRichTextBox.Text;
			 string s13=MasterComboBox.Text;
			 string s14= TerminalTextBox.Text;
			 
			 string s15=TerminalTextBox.Text;
			 string s16=AcumulatorTextBox.Text;
			 string s17=ZP1TextBox.Text;
			 string s18=ZP2TextBox.Text;
			 if(IsItExists==false){
			 mysql.exWithoutResult(@"start transaction;");
			mysql.exWithoutResult(@"insert into "+ZakazName+" (ViribName,virib_id, ViribModel,VlasnikName"+
		",VlasnikAdress,VlasnikHomeNumber,VlasnikWorkNumber,VlasnikMobileNumber,Skargi"
		+",VikonanaRobota,Primitki, Guarantee, SerialNumber, ExtraVidomosti,"+
		"MasterName) values('" +s1+ "',"+num+",'"+s2+"','"+s3+"','"+
		s4+"','"+s5+"','"+s6
		+"','"+s7+"','"+
		s8+"','"+s9+"','"+s10+"','"+
		s11+"',"+sn+",'"+s12+"','"+
		s13+"');");
			 	IsItExists=true;
			 	if(s15!="" || s16!="" || s17!="" || GarTalonCheckBox.Checked ||
			 	   RemoteCheckBox.Checked || WiresCheckBox.Checked){
			 		bool b1=GarTalonCheckBox.Checked;
			 		bool b2=RemoteCheckBox.Checked;
			 		bool b3=WiresCheckBox.Checked;
			 		mysql.exWithoutResult(@"insert into extra_info (virib_id,"
					+"TerminalNum,AcumNum,ZPvidEM,ZPvidSigi,GarTalon,Pult,Wire)"+
				" values ("+num+",'"+s15+"','"+s16+"','"+s17+"','"+s18+"',"+b1+
				","+b2+","+b3+");");
			 	}
			 	mysql.exWithoutResult(@"commit;");
			 }
			 if(IsItExists==true){
			 	int ZC=0;
			 	int AC=0;
			 	if(ZapchastiCostTextBox.Text!="") ZC=Int32.Parse(ZapchastiCostTextBox.Text);
			 	if(AllCostTextBox.Text!="" && AllCostTextBox.Text!="0") {
			 		AC=Int32.Parse(AllCostTextBox.Text); 
			 		VidachaButton.Enabled=true;
			 	}
			 	mysql.exWithoutResult(@"start transaction;");
			 mysql.exWithoutResult(@"update "+ZakazName+" set ViribName='" +s1+ "',"+
		"ViribModel='"+s2+"',VlasnikName='"+s3+"',VlasnikAdress='"+
		s4+"',VlasnikHomeNumber='"+s5+"',VlasnikWorkNumber='"+s6
		+"',VlasnikMobileNumber='"+s7+"',Skargi='"+
		s8+"',VikonanaRobota='"+s9+"',Primitki='"+s10+"',Guarantee='"+
		s11+"', SerialNumber="+sn+",ExtraVidomosti='"+s12+"',MasterName='"+
		s13+"', Zapchasticost="+ZC+",TotalCost="+AC+" where virib_id="+num+";");
			 	mysql.exWithoutResult(@"commit;");
			}
			}
			if(IsSearchModeOn==true){
				Search();
			}
		}
		
		void SetColors(Color c){
				NumberTextBox.BackColor=c;
				VirybNameTextBox.BackColor=c;;
				VuribModelTextBox.BackColor=c;
				ClientNameTextBox.BackColor=c;
				ClientAdressTextBox.BackColor=c;
				ClientHomeNumberTextBox.BackColor=c;
				ClientWorkNumberTextBox.BackColor=c;
				ClientMobileNumberTextBox.BackColor=c;
				SkargiTextBox.BackColor=c;
				MadeWorkRichTextBox.BackColor=c;
				PrimitkiTextBox.BackColor=c;
				GuaranteeComboBox.BackColor=c;
				SerialNumberTextBox.BackColor=c;
				ExtraInfoRichTextBox.BackColor=c;
				MasterComboBox.BackColor=c;
				ZapchastiCostTextBox.BackColor=c;
				AllCostTextBox.BackColor=c;
				PrijomDateTextBox.BackColor=c;
				VidanoTextBox.BackColor=c;
				ClientInformatedTextBox.BackColor=c;
				GuaranteeExpireTextBox.BackColor=c;
				TerminalTextBox.BackColor=c;
				AcumulatorTextBox.BackColor=c;
				ZP1TextBox.BackColor=c;
				ZP2TextBox.BackColor=c;
		}
		
		void CopyButtonClick(object sender, EventArgs e)
		{
			if(CopyButton.Text=="Зробити копію"){
				CopyName=ClientNameTextBox.Text;
				CopyHomePhoneNumber=ClientHomeNumberTextBox.Text;
				CopyWorkPhoneNumber=ClientWorkNumberTextBox.Text;
				CopyMobilePhoneNumber=ClientMobileNumberTextBox.Text;
				CopyAdress=ClientAdressTextBox.Text;
				CopyButton.Text="Вставити копію";
			}
			else{
				ClientNameTextBox.Text=CopyName;
				ClientHomeNumberTextBox.Text=CopyHomePhoneNumber;
				ClientWorkNumberTextBox.Text=CopyWorkPhoneNumber;
				ClientMobileNumberTextBox.Text=CopyMobilePhoneNumber;
				ClientAdressTextBox.Text=CopyAdress;
				CopyButton.Text="Зробити копію";
			}
		}
	protected override bool ProcessCmdKey(ref Message msg, Keys keydata){
		if(keydata== (Keys.F3)){
			SearchButton.PerformClick();
		} else if(keydata== (Keys.F1)){
			PriyomButtom.PerformClick();
		}else if(keydata== (Keys.F12)){
			OKButton.PerformClick();
			} else if(keydata== Keys.F5){
				VidachaButton.PerformClick();
			}
		return base.ProcessCmdKey(ref msg, keydata);
		}
		

		
		void ClientInformatedButtonClick(object sender, EventArgs e)
		{
			if(IsInTable){
			MySQL mysql = new MySQL();
			DateTime myDateTime=DateTime.Now;
			ClientInformatedTextBox.Text=myDateTime.ToString("dd-MM-yyyy");
			mysql.exWithResult(@"update dates set Info_date='"+
			                   myDateTime.Date.ToString("yyyyMMdd")+"' where virib_id="+
			                   Int32.Parse(NumberTextBox.Text)+";");
			}
		}
		
		void VidachaButtonClick(object sender, EventArgs e)
		{
			if(IsInTable){
			DialogResult result = MessageBox.Show("Хочете видати виріб клієнту?", 
			 "Підтвердження", MessageBoxButtons.YesNoCancel);
			if(result==DialogResult.No){
				ReadyLabel.Visible=true;
			}else if(result== DialogResult.Yes){
				MySQL mysql = new MySQL();
				DateTime myDateTime=DateTime.Now;
				VidanoTextBox.Text=myDateTime.ToString("dd-MM-yyyy");
				mysql.exWithResult(@"update "+ZakazName+ " set Vidacha_date='"+
			        myDateTime.Date.ToString("yyyyMMdd")+"' where virib_id="+
			    	Int32.Parse(NumberTextBox.Text)+";");				
			}
				
			}
		}
		void SetDataGridValues(){
			try{
			if(IsInTable==false){
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || 
				   row.Cells[0].Value.ToString()=="masters" ||
				   row.Cells[0].Value.ToString()=="vurib"
				  || row.Cells[0].Value.ToString()=="dates" 
				  || row.Cells[0].Value.ToString()=="extra_info")
					row.Visible=false;
				}
				} else if(IsInTable){
					foreach(DataGridViewRow row in MainDataGrid.Rows)
						for (int i = 2; i < MainDataGrid.ColumnCount; i++) {
						MainDataGrid.Columns[i].Visible=false;
						}
				}
			}
			catch(Exception ex){};
		}
		
	
		
		void InRemontRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			if(IsInTable){
				if(InRemontRadioButton.Checked){
					MySQL mysql = new MySQL();
					MainDataGrid.DataSource=mysql.exWithResult(@"select * from "
					+ZakazName+" where TotalCost=0");
					SetDataGridValues();
				}
			}
		}
		
		void VidaniRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			if(IsInTable){
				if(VidaniRadioButton.Checked){
					MySQL mysql = new MySQL();
					MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+ZakazName+ 
					 " where "+ZakazName+".Vidacha_date is not null;");
					SetDataGridValues();
				}
			}
		}
		
		void MadeRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			if(IsInTable){
				if(MadeRadioButton.Checked){
					MySQL mysql = new MySQL();
					MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+ZakazName+ 
					  " where "+ZakazName+".Vidacha_date is null" +
					 " and "+ZakazName+".TotalCost<>0;");
					SetDataGridValues();
				}
			}
		}
		
		void AllRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			if(IsInTable){
				if(AllRadioButton.Checked){
					MySQL mysql = new MySQL();
					MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+ZakazName+" ;");
					SetDataGridValues();
				}
			}
		}
		
		void Search(){
		SetColors(SystemColors.Window);
				IsSearchModeOn=false;
				MySQL mysql = new MySQL();
				StringBuilder querry= new StringBuilder();
				int rowcount = MainDataGrid.DisplayedRowCount(false);
				string findnum = NumberTextBox.Text;
				string[] tablenames = new string[rowcount];
				for (int i = 0; i < rowcount; i++) {
						string str = MainDataGrid.Rows[i].Cells[0].Value.ToString();
					if(str!="firmi" && str!="masters" && str!="vurib")
						tablenames[i]=str;
					}
				if(findnum!=""){ 
					querry.Append("start transaction; ");
					querry.Append("select * from( (");
					for (int i = 0; i < rowcount; i++) {
						if(tablenames[i]!="vurib" && tablenames[i]!="masters" && tablenames[i]!="firmi"){
						if(i < rowcount)
						querry.Append("select ViribName,virib_id,ViribModel," +
						"VlasnikName, VlasnikAdress, VlasnikHomeNumber," +
						"VlasnikWorkNumber, VlasnikMobileNumber," +
						"Skargi, VikonanaRobota, Primitki," +
						"Guarantee, SerialNumber, ExtraVidomosti, " +
			"MasterName, ZapchastiCost, TotalCost as virib_id"+i+" from "+tablenames[i]+")");
					if(i<rowcount-1) querry.Append( " union all ( ");
				}
			}
				
					querry.Append(") as t where virib_id="+findnum+";");
					querry.Append("commit;");
				} 
					
					else if(VidanoTextBox.Text!=""){
					querry.Append("start transaction; ");
					IsSelectedForKassa=true;
					string s=VidanoTextBox.Text;
					StringBuilder s2= new StringBuilder();
					s2.Append(s.Substring(6,4));
					s2.Append("-");
					s2.Append(s.Substring(3,2));
					s2.Append("-");
					s2.Append(s.Substring(0,2));
					if(MasterComboBox.Text==""){
					for (int i = 0; i < rowcount; i++) {
						if(tablenames[i]!="vurib" && tablenames[i]!="masters" && tablenames[i]!="firmi"){
							if(i < rowcount){
						querry.Append("select *  from "+tablenames[i]+" where " +
								              "vidacha_date='"+s2.ToString()+"'");}
						if(i<rowcount-1) querry.Append( " union all ");
						}
					}
						querry.Append(";");
						querry.Append("commit;");
					}
					else if(MasterComboBox.Text!=""){
						querry.Append("start transaction;");
						IsSelectedMasterSalary=true;	
						IsSelectedForKassa=true; ///
					for (int i = 0; i < rowcount; i++) {
						if(tablenames[i]!="vurib" && tablenames[i]!="masters" && tablenames[i]!="firmi"){
							if(i < rowcount){
						querry.Append("select *  from "+tablenames[i]+" where " +
								              "MasterName='"+MasterComboBox.Text.ToString()+"'"+
								              " and vidacha_date='"+s2.ToString()+"'");}
						if(i<rowcount-1) querry.Append( " union all ");
				
						}
						
					}
						querry.Append(";");
						querry.Append("commit;");
				}
				}  
				
			try{
			MainDataGrid.DataSource=mysql.exWithResult(querry.ToString());
			IsInTable=true;
			mysql.exWithoutResult("start transaction;");
			DateTimeDataGridView.DataSource=mysql.exWithResult(@"select * from dates"+
			"where virib_id="+findnum+";");
			mysql.exWithoutResult("commit;");
			IsInTable=true;
			}
			catch(Exception ex) {};
			SetDataGridValues();
			SetAllValues();
		}
			
		
		void PrintButtonClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from телевизоры where Vidacha_date='2016-12-11'
			union all
			select * from стиралки where Vidacha_date='2016-12-11';");
			IsInTable=true;
			SetAllValues();
		}
		
		void AddTablePictureBoxClick(object sender, EventArgs e)
		{
			AddTableForm form = new AddTableForm();
			form.Show();
		}
		
		void GuaranteeDateTimePickerValueChanged(object sender, EventArgs e)
		{
			if(IsInTable && IsItExists){
			string myDateTime = GuaranteeDateTimePicker.Value.ToString();
			GuaranteeExpireTextBox.Text= myDateTime.Substring(0,10);
			StringBuilder s2= new StringBuilder();
					s2.Append(myDateTime.Substring(6,4));
					s2.Append("-");
					s2.Append(myDateTime.Substring(3,2));
					s2.Append("-");
					s2.Append(myDateTime.Substring(0,2));
					MySQL mysql = new MySQL();
				mysql.exWithResult(@"update dates set Vidacha_date='"+
					                   s2.ToString()+"' where virib_id="+
					                   Int32.Parse(NumberTextBox.Text)+";");
			}
		}
		
		void SearchFirmButtonClick(object sender, EventArgs e)
		{
			if(IsInTable){
				if(SearchFirmButton.Text=="Пошук за фірмою"){
				ClearAllValues();
				SetColors(SystemColors.ActiveCaption);
				SearchFirmButton.Text="Шукати";
				} else if(SearchFirmButton.Text=="Шукати"){
					if(GuaranteeComboBox.Text==""){ MessageBox.Show("Оберіть фірму","Error");
					}else {
						MySQL mysql = new MySQL();
						MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+
						ZakazName+" where guarantee='"+GuaranteeComboBox.Text+"';");
						SetColors(SystemColors.Window);
						SearchFirmButton.Text="Пошук за фірмою";
					}
				}
			} 
		}
		
		void FindSalaryButtonClick(object sender, EventArgs e)
		{
			if(IsSelectedMasterSalary){
				double Money=0;
				foreach(DataGridViewRow row in MainDataGrid.Rows){
					Money+=Int32.Parse(row.Cells[16].Value.ToString());
				}
				double persents = Double.Parse(MasterSalaryTextBox.Text);
				persents/=100;
				Money*=persents;
				MessageBox.Show("Зарплата мастера " +MasterComboBox.Text+" составляет:"+Money);
				IsSelectedMasterSalary=false;
				MasterSalaryTextBox.Text="";
			}
		}
		
		void KassaButtonClick(object sender, EventArgs e)
		{
			if(IsSelectedForKassa){
				int Zapchasti=0;
				int Money=0;
				foreach(DataGridViewRow row in MainDataGrid.Rows){
					Zapchasti+=Int32.Parse(row.Cells[15].Value.ToString());
					Money+=Int32.Parse(row.Cells[16].Value.ToString());
				}
				IsSelectedForKassa=false;
				MessageBox.Show("Запчасти: " +Zapchasti+ " Полная сумма: "+Money);
			}
		}
	}
}
