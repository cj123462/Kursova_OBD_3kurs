/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10.12.2016
 * Time: 9:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Zverev_Kursova_OBD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainDataGrid = new System.Windows.Forms.DataGridView();
			this.RadioGroupPanel = new System.Windows.Forms.Panel();
			this.SecondDateComboBox = new System.Windows.Forms.ComboBox();
			this.FirstDateComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.UseDateCheckBox = new System.Windows.Forms.CheckBox();
			this.GuarranteeRadioButton = new System.Windows.Forms.RadioButton();
			this.PovtorRadioButton = new System.Windows.Forms.RadioButton();
			this.MadeRadioButton = new System.Windows.Forms.RadioButton();
			this.VidaniRadioButton = new System.Windows.Forms.RadioButton();
			this.InRemontRadioButton = new System.Windows.Forms.RadioButton();
			this.AllRadioButton = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.NumberTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PrijomDateTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.VidanoTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.VirybNameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.VuribModelTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ClientInfoPanel = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.ClientInformatedTextBox = new System.Windows.Forms.TextBox();
			this.ClientInformatedButton = new System.Windows.Forms.Button();
			this.ClientMobileNumberTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.ClientWorkNumberTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ClientHomeNumberTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.ClientAdressTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.ClientNameTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.VuribInfoPanel = new System.Windows.Forms.Panel();
			this.PrimitkiTextBox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.MadeWorkRichTextBox = new System.Windows.Forms.RichTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.SkargiTextBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.GuaranteeInfoPanel = new System.Windows.Forms.Panel();
			this.ExtraInfoRichTextBox = new System.Windows.Forms.RichTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.GuaranteeComboBox = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
			this.RadioGroupPanel.SuspendLayout();
			this.ClientInfoPanel.SuspendLayout();
			this.VuribInfoPanel.SuspendLayout();
			this.GuaranteeInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainDataGrid
			// 
			this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainDataGrid.Location = new System.Drawing.Point(12, 12);
			this.MainDataGrid.Name = "MainDataGrid";
			this.MainDataGrid.Size = new System.Drawing.Size(180, 636);
			this.MainDataGrid.TabIndex = 0;
			this.MainDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridCellClick);
			// 
			// RadioGroupPanel
			// 
			this.RadioGroupPanel.BackColor = System.Drawing.SystemColors.Control;
			this.RadioGroupPanel.Controls.Add(this.SecondDateComboBox);
			this.RadioGroupPanel.Controls.Add(this.FirstDateComboBox);
			this.RadioGroupPanel.Controls.Add(this.label2);
			this.RadioGroupPanel.Controls.Add(this.label1);
			this.RadioGroupPanel.Controls.Add(this.UseDateCheckBox);
			this.RadioGroupPanel.Controls.Add(this.GuarranteeRadioButton);
			this.RadioGroupPanel.Controls.Add(this.PovtorRadioButton);
			this.RadioGroupPanel.Controls.Add(this.MadeRadioButton);
			this.RadioGroupPanel.Controls.Add(this.VidaniRadioButton);
			this.RadioGroupPanel.Controls.Add(this.InRemontRadioButton);
			this.RadioGroupPanel.Controls.Add(this.AllRadioButton);
			this.RadioGroupPanel.Location = new System.Drawing.Point(198, 12);
			this.RadioGroupPanel.Name = "RadioGroupPanel";
			this.RadioGroupPanel.Size = new System.Drawing.Size(413, 124);
			this.RadioGroupPanel.TabIndex = 1;
			// 
			// SecondDateComboBox
			// 
			this.SecondDateComboBox.FormattingEnabled = true;
			this.SecondDateComboBox.Location = new System.Drawing.Point(234, 70);
			this.SecondDateComboBox.Name = "SecondDateComboBox";
			this.SecondDateComboBox.Size = new System.Drawing.Size(121, 21);
			this.SecondDateComboBox.TabIndex = 10;
			// 
			// FirstDateComboBox
			// 
			this.FirstDateComboBox.FormattingEnabled = true;
			this.FirstDateComboBox.Location = new System.Drawing.Point(234, 41);
			this.FirstDateComboBox.Name = "FirstDateComboBox";
			this.FirstDateComboBox.Size = new System.Drawing.Size(121, 21);
			this.FirstDateComboBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(198, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "До:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(198, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "З:";
			// 
			// UseDateCheckBox
			// 
			this.UseDateCheckBox.Location = new System.Drawing.Point(203, 4);
			this.UseDateCheckBox.Name = "UseDateCheckBox";
			this.UseDateCheckBox.Size = new System.Drawing.Size(138, 24);
			this.UseDateCheckBox.TabIndex = 6;
			this.UseDateCheckBox.Text = "Враховувати дату";
			this.UseDateCheckBox.UseVisualStyleBackColor = true;
			// 
			// GuarranteeRadioButton
			// 
			this.GuarranteeRadioButton.Location = new System.Drawing.Point(93, 33);
			this.GuarranteeRadioButton.Name = "GuarranteeRadioButton";
			this.GuarranteeRadioButton.Size = new System.Drawing.Size(104, 24);
			this.GuarranteeRadioButton.TabIndex = 5;
			this.GuarranteeRadioButton.TabStop = true;
			this.GuarranteeRadioButton.Text = "Гарантійні";
			this.GuarranteeRadioButton.UseVisualStyleBackColor = true;
			// 
			// PovtorRadioButton
			// 
			this.PovtorRadioButton.Location = new System.Drawing.Point(93, 3);
			this.PovtorRadioButton.Name = "PovtorRadioButton";
			this.PovtorRadioButton.Size = new System.Drawing.Size(104, 24);
			this.PovtorRadioButton.TabIndex = 4;
			this.PovtorRadioButton.TabStop = true;
			this.PovtorRadioButton.Text = "Повторні";
			this.PovtorRadioButton.UseVisualStyleBackColor = true;
			// 
			// MadeRadioButton
			// 
			this.MadeRadioButton.Location = new System.Drawing.Point(3, 92);
			this.MadeRadioButton.Name = "MadeRadioButton";
			this.MadeRadioButton.Size = new System.Drawing.Size(152, 24);
			this.MadeRadioButton.TabIndex = 3;
			this.MadeRadioButton.TabStop = true;
			this.MadeRadioButton.Text = "Виконані замовлення";
			this.MadeRadioButton.UseVisualStyleBackColor = true;
			// 
			// VidaniRadioButton
			// 
			this.VidaniRadioButton.Location = new System.Drawing.Point(3, 62);
			this.VidaniRadioButton.Name = "VidaniRadioButton";
			this.VidaniRadioButton.Size = new System.Drawing.Size(104, 24);
			this.VidaniRadioButton.TabIndex = 2;
			this.VidaniRadioButton.TabStop = true;
			this.VidaniRadioButton.Text = "Видані";
			this.VidaniRadioButton.UseVisualStyleBackColor = true;
			// 
			// InRemontRadioButton
			// 
			this.InRemontRadioButton.Location = new System.Drawing.Point(3, 32);
			this.InRemontRadioButton.Name = "InRemontRadioButton";
			this.InRemontRadioButton.Size = new System.Drawing.Size(104, 24);
			this.InRemontRadioButton.TabIndex = 1;
			this.InRemontRadioButton.TabStop = true;
			this.InRemontRadioButton.Text = "У ремонті";
			this.InRemontRadioButton.UseVisualStyleBackColor = true;
			// 
			// AllRadioButton
			// 
			this.AllRadioButton.Location = new System.Drawing.Point(3, 3);
			this.AllRadioButton.Name = "AllRadioButton";
			this.AllRadioButton.Size = new System.Drawing.Size(109, 23);
			this.AllRadioButton.TabIndex = 0;
			this.AllRadioButton.TabStop = true;
			this.AllRadioButton.Text = "Всі";
			this.AllRadioButton.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(198, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "№ заказу:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumberTextBox
			// 
			this.NumberTextBox.Location = new System.Drawing.Point(263, 149);
			this.NumberTextBox.Name = "NumberTextBox";
			this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.NumberTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(396, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Прийнято:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PrijomDateTextBox
			// 
			this.PrijomDateTextBox.Location = new System.Drawing.Point(463, 149);
			this.PrijomDateTextBox.Name = "PrijomDateTextBox";
			this.PrijomDateTextBox.Size = new System.Drawing.Size(100, 20);
			this.PrijomDateTextBox.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(583, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Видано:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VidanoTextBox
			// 
			this.VidanoTextBox.Location = new System.Drawing.Point(637, 149);
			this.VidanoTextBox.Name = "VidanoTextBox";
			this.VidanoTextBox.Size = new System.Drawing.Size(100, 20);
			this.VidanoTextBox.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(198, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Виріб:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VirybNameTextBox
			// 
			this.VirybNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VirybNameTextBox.ForeColor = System.Drawing.Color.Blue;
			this.VirybNameTextBox.Location = new System.Drawing.Point(291, 175);
			this.VirybNameTextBox.Name = "VirybNameTextBox";
			this.VirybNameTextBox.Size = new System.Drawing.Size(174, 22);
			this.VirybNameTextBox.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(471, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Модель:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VuribModelTextBox
			// 
			this.VuribModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VuribModelTextBox.ForeColor = System.Drawing.Color.Blue;
			this.VuribModelTextBox.Location = new System.Drawing.Point(556, 174);
			this.VuribModelTextBox.Name = "VuribModelTextBox";
			this.VuribModelTextBox.Size = new System.Drawing.Size(181, 22);
			this.VuribModelTextBox.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(198, 198);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(121, 18);
			this.label8.TabIndex = 12;
			this.label8.Text = "Відомості про клієнта:";
			// 
			// ClientInfoPanel
			// 
			this.ClientInfoPanel.BackColor = System.Drawing.SystemColors.Control;
			this.ClientInfoPanel.Controls.Add(this.label14);
			this.ClientInfoPanel.Controls.Add(this.ClientInformatedTextBox);
			this.ClientInfoPanel.Controls.Add(this.ClientInformatedButton);
			this.ClientInfoPanel.Controls.Add(this.ClientMobileNumberTextBox);
			this.ClientInfoPanel.Controls.Add(this.label13);
			this.ClientInfoPanel.Controls.Add(this.ClientWorkNumberTextBox);
			this.ClientInfoPanel.Controls.Add(this.label12);
			this.ClientInfoPanel.Controls.Add(this.ClientHomeNumberTextBox);
			this.ClientInfoPanel.Controls.Add(this.label11);
			this.ClientInfoPanel.Controls.Add(this.ClientAdressTextBox);
			this.ClientInfoPanel.Controls.Add(this.label10);
			this.ClientInfoPanel.Controls.Add(this.ClientNameTextBox);
			this.ClientInfoPanel.Controls.Add(this.label9);
			this.ClientInfoPanel.Location = new System.Drawing.Point(198, 219);
			this.ClientInfoPanel.Name = "ClientInfoPanel";
			this.ClientInfoPanel.Size = new System.Drawing.Size(539, 144);
			this.ClientInfoPanel.TabIndex = 13;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(311, 109);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(208, 23);
			this.label14.TabIndex = 12;
			this.label14.Text = "Замовлення виконано!!!";
			this.label14.Visible = false;
			// 
			// ClientInformatedTextBox
			// 
			this.ClientInformatedTextBox.Location = new System.Drawing.Point(419, 73);
			this.ClientInformatedTextBox.Name = "ClientInformatedTextBox";
			this.ClientInformatedTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientInformatedTextBox.TabIndex = 11;
			// 
			// ClientInformatedButton
			// 
			this.ClientInformatedButton.Location = new System.Drawing.Point(311, 71);
			this.ClientInformatedButton.Name = "ClientInformatedButton";
			this.ClientInformatedButton.Size = new System.Drawing.Size(102, 23);
			this.ClientInformatedButton.TabIndex = 10;
			this.ClientInformatedButton.Text = "Повідомлено";
			this.ClientInformatedButton.UseVisualStyleBackColor = true;
			// 
			// ClientMobileNumberTextBox
			// 
			this.ClientMobileNumberTextBox.Location = new System.Drawing.Point(110, 112);
			this.ClientMobileNumberTextBox.Name = "ClientMobileNumberTextBox";
			this.ClientMobileNumberTextBox.Size = new System.Drawing.Size(181, 20);
			this.ClientMobileNumberTextBox.TabIndex = 9;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(7, 109);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 23);
			this.label13.TabIndex = 8;
			this.label13.Text = "Мобільний:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClientWorkNumberTextBox
			// 
			this.ClientWorkNumberTextBox.Location = new System.Drawing.Point(110, 84);
			this.ClientWorkNumberTextBox.Name = "ClientWorkNumberTextBox";
			this.ClientWorkNumberTextBox.Size = new System.Drawing.Size(181, 20);
			this.ClientWorkNumberTextBox.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(26, 84);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 23);
			this.label12.TabIndex = 6;
			this.label12.Text = "Робочі: ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClientHomeNumberTextBox
			// 
			this.ClientHomeNumberTextBox.Location = new System.Drawing.Point(110, 59);
			this.ClientHomeNumberTextBox.Name = "ClientHomeNumberTextBox";
			this.ClientHomeNumberTextBox.Size = new System.Drawing.Size(181, 20);
			this.ClientHomeNumberTextBox.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(26, 61);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "Домашні:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClientAdressTextBox
			// 
			this.ClientAdressTextBox.Location = new System.Drawing.Point(86, 36);
			this.ClientAdressTextBox.Name = "ClientAdressTextBox";
			this.ClientAdressTextBox.Size = new System.Drawing.Size(450, 20);
			this.ClientAdressTextBox.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(7, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Адреса:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClientNameTextBox
			// 
			this.ClientNameTextBox.Location = new System.Drawing.Point(86, 10);
			this.ClientNameTextBox.Name = "ClientNameTextBox";
			this.ClientNameTextBox.Size = new System.Drawing.Size(450, 20);
			this.ClientNameTextBox.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(3, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Власник:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VuribInfoPanel
			// 
			this.VuribInfoPanel.BackColor = System.Drawing.SystemColors.Control;
			this.VuribInfoPanel.Controls.Add(this.PrimitkiTextBox);
			this.VuribInfoPanel.Controls.Add(this.label17);
			this.VuribInfoPanel.Controls.Add(this.MadeWorkRichTextBox);
			this.VuribInfoPanel.Controls.Add(this.label16);
			this.VuribInfoPanel.Controls.Add(this.SkargiTextBox);
			this.VuribInfoPanel.Controls.Add(this.label15);
			this.VuribInfoPanel.Location = new System.Drawing.Point(198, 369);
			this.VuribInfoPanel.Name = "VuribInfoPanel";
			this.VuribInfoPanel.Size = new System.Drawing.Size(597, 127);
			this.VuribInfoPanel.TabIndex = 14;
			// 
			// PrimitkiTextBox
			// 
			this.PrimitkiTextBox.Location = new System.Drawing.Point(110, 96);
			this.PrimitkiTextBox.Name = "PrimitkiTextBox";
			this.PrimitkiTextBox.Size = new System.Drawing.Size(484, 20);
			this.PrimitkiTextBox.TabIndex = 5;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(12, 93);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(95, 23);
			this.label17.TabIndex = 4;
			this.label17.Text = "Примітки:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MadeWorkRichTextBox
			// 
			this.MadeWorkRichTextBox.Location = new System.Drawing.Point(110, 40);
			this.MadeWorkRichTextBox.Name = "MadeWorkRichTextBox";
			this.MadeWorkRichTextBox.Size = new System.Drawing.Size(484, 50);
			this.MadeWorkRichTextBox.TabIndex = 3;
			this.MadeWorkRichTextBox.Text = "";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(7, 35);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 38);
			this.label16.TabIndex = 2;
			this.label16.Text = "Виконана робота:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SkargiTextBox
			// 
			this.SkargiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SkargiTextBox.ForeColor = System.Drawing.Color.Blue;
			this.SkargiTextBox.Location = new System.Drawing.Point(110, 14);
			this.SkargiTextBox.Name = "SkargiTextBox";
			this.SkargiTextBox.Size = new System.Drawing.Size(484, 22);
			this.SkargiTextBox.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(7, 12);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 0;
			this.label15.Text = "Скарги:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GuaranteeInfoPanel
			// 
			this.GuaranteeInfoPanel.BackColor = System.Drawing.SystemColors.Control;
			this.GuaranteeInfoPanel.Controls.Add(this.ExtraInfoRichTextBox);
			this.GuaranteeInfoPanel.Controls.Add(this.label21);
			this.GuaranteeInfoPanel.Controls.Add(this.SerialNumberTextBox);
			this.GuaranteeInfoPanel.Controls.Add(this.label20);
			this.GuaranteeInfoPanel.Controls.Add(this.GuaranteeComboBox);
			this.GuaranteeInfoPanel.Controls.Add(this.label19);
			this.GuaranteeInfoPanel.Location = new System.Drawing.Point(198, 516);
			this.GuaranteeInfoPanel.Name = "GuaranteeInfoPanel";
			this.GuaranteeInfoPanel.Size = new System.Drawing.Size(597, 90);
			this.GuaranteeInfoPanel.TabIndex = 15;
			// 
			// ExtraInfoRichTextBox
			// 
			this.ExtraInfoRichTextBox.Location = new System.Drawing.Point(107, 42);
			this.ExtraInfoRichTextBox.Name = "ExtraInfoRichTextBox";
			this.ExtraInfoRichTextBox.Size = new System.Drawing.Size(487, 40);
			this.ExtraInfoRichTextBox.TabIndex = 21;
			this.ExtraInfoRichTextBox.Text = "";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label21.Location = new System.Drawing.Point(12, 42);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(95, 40);
			this.label21.TabIndex = 20;
			this.label21.Text = "Додаткові відомості:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SerialNumberTextBox
			// 
			this.SerialNumberTextBox.Location = new System.Drawing.Point(408, 9);
			this.SerialNumberTextBox.Name = "SerialNumberTextBox";
			this.SerialNumberTextBox.Size = new System.Drawing.Size(186, 20);
			this.SerialNumberTextBox.TabIndex = 19;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label20.Location = new System.Drawing.Point(302, 13);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(111, 17);
			this.label20.TabIndex = 18;
			this.label20.Text = "Свідоцтво №";
			// 
			// GuaranteeComboBox
			// 
			this.GuaranteeComboBox.FormattingEnabled = true;
			this.GuaranteeComboBox.Location = new System.Drawing.Point(107, 9);
			this.GuaranteeComboBox.Name = "GuaranteeComboBox";
			this.GuaranteeComboBox.Size = new System.Drawing.Size(184, 21);
			this.GuaranteeComboBox.TabIndex = 17;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(7, 9);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 23);
			this.label19.TabIndex = 0;
			this.label19.Text = "Гарантія:";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(201, 499);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(142, 14);
			this.label18.TabIndex = 16;
			this.label18.Text = "Інформація про гарантію";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(807, 660);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.GuaranteeInfoPanel);
			this.Controls.Add(this.VuribInfoPanel);
			this.Controls.Add(this.ClientInfoPanel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.VuribModelTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.VirybNameTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.VidanoTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PrijomDateTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NumberTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RadioGroupPanel);
			this.Controls.Add(this.MainDataGrid);
			this.Name = "MainForm";
			this.Text = "Zverev_Kursova_OBD";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
			this.RadioGroupPanel.ResumeLayout(false);
			this.ClientInfoPanel.ResumeLayout(false);
			this.ClientInfoPanel.PerformLayout();
			this.VuribInfoPanel.ResumeLayout(false);
			this.VuribInfoPanel.PerformLayout();
			this.GuaranteeInfoPanel.ResumeLayout(false);
			this.GuaranteeInfoPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox GuaranteeComboBox;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox SerialNumberTextBox;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.RichTextBox ExtraInfoRichTextBox;
		private System.Windows.Forms.Panel GuaranteeInfoPanel;
		private System.Windows.Forms.TextBox PrimitkiTextBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox SkargiTextBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RichTextBox MadeWorkRichTextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Panel VuribInfoPanel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ClientHomeNumberTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox ClientWorkNumberTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox ClientMobileNumberTextBox;
		private System.Windows.Forms.Button ClientInformatedButton;
		private System.Windows.Forms.TextBox ClientInformatedTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox ClientAdressTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ClientNameTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel ClientInfoPanel;
		private System.Windows.Forms.TextBox VuribModelTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox VirybNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox VidanoTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PrijomDateTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox NumberTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton AllRadioButton;
		private System.Windows.Forms.RadioButton InRemontRadioButton;
		private System.Windows.Forms.RadioButton VidaniRadioButton;
		private System.Windows.Forms.RadioButton MadeRadioButton;
		private System.Windows.Forms.RadioButton PovtorRadioButton;
		private System.Windows.Forms.RadioButton GuarranteeRadioButton;
		private System.Windows.Forms.CheckBox UseDateCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox FirstDateComboBox;
		private System.Windows.Forms.ComboBox SecondDateComboBox;
		private System.Windows.Forms.Panel RadioGroupPanel;
		private System.Windows.Forms.DataGridView MainDataGrid;
	}
}
