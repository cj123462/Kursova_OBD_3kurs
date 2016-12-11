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
		string ZakazName="";
		string CopyName="";
		string CopyHomePhoneNumber="";
		string CopyWorkPhoneNumber="";
		string CopyMobilePhoneNumber="";
		string CopyAdress="";
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
				   row.Cells[0].Value.ToString()=="vurib"
				  || row.Cells[0].Value.ToString()=="dates")
					row.Visible=false;
				}
			}
			catch(Exception ex){};
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
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || row.Cells[0].Value.ToString()=="vurib" ||
					row.Cells[0].Value.ToString()=="masters" || row.Cells[0].Value.ToString()=="dates" )
					row.Visible=false;
				}
			}
			catch(Exception ex){};
			ClearAllValues();
			}
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
				DateTimeDataGridView.DataSource=mysql.exWithResult(@"select * from dates "+
				 "where virib_id="+Int32.Parse(NumberTextBox.Text)+";");
				string prijom = DateTimeDataGridView.Rows[0].Cells[1].Value.ToString();
				PrijomDateTextBox.Text=prijom.Substring(0,10);
				if(DateTimeDataGridView.Rows[0].Cells[1].Value.ToString()!=""){
				string info =DateTimeDataGridView.Rows[0].Cells[1].Value.ToString();
				ClientInformatedTextBox.Text=info.Substring(0,10);
				}
				if(DateTimeDataGridView.Rows[0].Cells[3].Value.ToString()!=""){
					string vidano=DateTimeDataGridView.Rows[0].Cells[3].Value.ToString();
					VidanoTextBox.Text=vidano.Substring(0,10);
				}
				if(VidanoTextBox.Text=="") {ReadyLabel.Visible=false;} else ReadyLabel.Visible=true;
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
		}
		void MainDataGridSelectionChanged(object sender, EventArgs e)
		{
			if(IsInTable==true){
				ClearAllValues();
			SetAllValues();
			}
			if(IsInTable==false) ClearAllValues();
			IsItExists=true;
		}
		
		void SearchButtonClick(object sender, EventArgs e)
		{
			IsInTable=false;
			ClearAllValues();
			MySQL mysql = new MySQL();
			MainDataGrid.DataSource=mysql.exWithResult(@"show tables");
			try{
			foreach(DataGridViewRow row in MainDataGrid.Rows){
				if(row.Cells[0].Value.ToString()=="firmi" || 
				   row.Cells[0].Value.ToString()=="masters" ||
				   row.Cells[0].Value.ToString()=="vurib")
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
			MainDataGrid.DataSource=mysql.exWithResult(@"select * from "+str+";");
			IsInTable=true;
			SetAllValues();
			}
		}
		
		void PriyomButtomClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			mysql.exWithoutResult(@"insert into vurib (void) values('');");
			NumberDataGridView.DataSource=mysql.exWithResult(@"select last_insert_id()");//(@"select * from vurib;");
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
			 if(IsItExists==false){
			 	
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
			 }
			 if(IsItExists==true){
			 mysql.exWithoutResult(@"update "+ZakazName+" set ViribName='" +s1+ "',"+
		"ViribModel='"+s2+"',VlasnikName='"+s3+"',VlasnikAdress='"+
		s4+"',VlasnikHomeNumber='"+s5+"',VlasnikWorkNumber='"+s6
		+"',VlasnikMobileNumber='"+s7+"',Skargi='"+
		s8+"',VikonanaRobota='"+s9+"',Primitki='"+s10+"',Guarantee='"+
		s11+"', SerialNumber="+sn+",ExtraVidomosti='"+s12+"',MasterName='"+
		s13+"' where virib_id="+num+";");
			}
			}
			if(IsSearchModeOn==true){
				SetColors(SystemColors.Window);
				IsSearchModeOn=false;
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
			DateTimeDataGridView.DataSource=mysql.exWithResult(@"select * from dates"+
			"where virib_id="+findnum+";");
			PrijomDateTextBox.Text=DateTimeDataGridView.Rows[0].Cells[0].Value.ToString();
			SetAllValues();
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
			                   Int32.Parse(NumberTextBox.Text)+";");}
		}
		
		void VidachaButtonClick(object sender, EventArgs e)
		{
			if(IsInTable){
			MySQL mysql = new MySQL();
			DateTime myDateTime=DateTime.Now;
			VidanoTextBox.Text=myDateTime.ToString("dd-MM-yyyy");
			mysql.exWithResult(@"update dates set Vidacha_date='"+
			                   myDateTime.Date.ToString("yyyyMMdd")+"' where virib_id="+
			                   Int32.Parse(NumberTextBox.Text)+";");
			ReadyLabel.Visible=true;
			}
		}
	}
}
