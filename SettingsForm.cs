/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10.12.2016
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zverev_Kursova_OBD
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}
		
		void SettingsFormLoad(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			mysql.connect("localhost","root","1","zverev_kursova_obd");
			SettingsMastersDataGridView.DataSource=mysql.exWithResult(@"select master_name from masters");
			SettingsFirmiDataGridView.DataSource=mysql.exWithResult(@"select Firm_name from firmi");
		}
		
		void AddMasterButtonClick(object sender, EventArgs e)
		{
			if(SettingsMasterTextBox.Text!=""){
			MySQL mysql = new MySQL();
			mysql.exWithoutResult(@"insert into masters (Master_name) values('"
			                      +SettingsMasterTextBox.Text+"');");
			} else MessageBox.Show("Введите название", "Error");
		}
		
		void DropMasterButtonClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			int id= SettingsMastersDataGridView.CurrentRow.Index;
			mysql.exWithoutResult(@"delete from masters where Master_name='"+
			                      SettingsMastersDataGridView.Rows[id].Cells[0].Value.ToString()+
			                     "';");
		}
		
		void AddFirmaButtonClick(object sender, EventArgs e)
		{
			if(SettingsFirmaTextBox.Text!=""){
			MySQL mysql = new MySQL();
			mysql.exWithoutResult(@"insert into firmi (Firm_name) values('"
			                      +SettingsFirmaTextBox.Text+"');");
			} else MessageBox.Show("Введите название", "Error");
		}
		
		void DropFirmaButtonClick(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			int id= SettingsFirmiDataGridView.CurrentRow.Index;
			mysql.exWithoutResult(@"delete from firmi where Firm_name='"+
			                      SettingsFirmiDataGridView.Rows[id].Cells[0].Value.ToString()+
			                     "';");
		}
	}
}
