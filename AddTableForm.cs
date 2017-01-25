/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 11.12.2016
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zverev_Kursova_OBD
{
	/// <summary>
	/// Description of AddTableForm.
	/// </summary>
	public partial class AddTableForm : Form
	{
		public AddTableForm()
		{
			InitializeComponent();
		}

		
		void AddTableFormLoad(object sender, EventArgs e)
		{
			MySQL mysql = new MySQL();
			mysql.connect("localhost","root","1","zverev_kursova_obd");
		}
		
		void AddTableButtonClick(object sender, EventArgs e)
		{
			if(NewTableTextBox.Text!=""){
				MySQL mysql = new MySQL();
				mysql.exWithoutResult(@"create table "+NewTableTextBox.Text+
				                     " like холодильники;");
				mysql.exWithoutResult(@"alter table "+NewTableTextBox.Text+" drop column Id");
				mysql.exWithoutResult(@"alter table " +NewTableTextBox.Text+
				" add column Id int (11), add foreign key fk_name (Id) references vurib(Id);");
			} else MessageBox.Show("Введіть назву таблиці","Error");
		}
	}
}
