/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 10.12.2016
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Zverev_Kursova_OBD
{
	partial class SettingsForm
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
			this.SettingsMastersDataGridView = new System.Windows.Forms.DataGridView();
			this.SettingsMasterTextBox = new System.Windows.Forms.TextBox();
			this.AddMasterButton = new System.Windows.Forms.Button();
			this.DropMasterButton = new System.Windows.Forms.Button();
			this.SettingsFirmiDataGridView = new System.Windows.Forms.DataGridView();
			this.DropFirmaButton = new System.Windows.Forms.Button();
			this.AddFirmaButton = new System.Windows.Forms.Button();
			this.SettingsFirmaTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.SettingsMastersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SettingsFirmiDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SettingsMastersDataGridView
			// 
			this.SettingsMastersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SettingsMastersDataGridView.Location = new System.Drawing.Point(12, 92);
			this.SettingsMastersDataGridView.Name = "SettingsMastersDataGridView";
			this.SettingsMastersDataGridView.Size = new System.Drawing.Size(194, 252);
			this.SettingsMastersDataGridView.TabIndex = 0;
			// 
			// SettingsMasterTextBox
			// 
			this.SettingsMasterTextBox.Location = new System.Drawing.Point(12, 65);
			this.SettingsMasterTextBox.Name = "SettingsMasterTextBox";
			this.SettingsMasterTextBox.Size = new System.Drawing.Size(194, 20);
			this.SettingsMasterTextBox.TabIndex = 1;
			// 
			// AddMasterButton
			// 
			this.AddMasterButton.Location = new System.Drawing.Point(12, 36);
			this.AddMasterButton.Name = "AddMasterButton";
			this.AddMasterButton.Size = new System.Drawing.Size(92, 23);
			this.AddMasterButton.TabIndex = 2;
			this.AddMasterButton.Text = "Добавить ";
			this.AddMasterButton.UseVisualStyleBackColor = true;
			this.AddMasterButton.Click += new System.EventHandler(this.AddMasterButtonClick);
			// 
			// DropMasterButton
			// 
			this.DropMasterButton.Location = new System.Drawing.Point(110, 36);
			this.DropMasterButton.Name = "DropMasterButton";
			this.DropMasterButton.Size = new System.Drawing.Size(96, 23);
			this.DropMasterButton.TabIndex = 3;
			this.DropMasterButton.Text = "Удалить";
			this.DropMasterButton.UseVisualStyleBackColor = true;
			this.DropMasterButton.Click += new System.EventHandler(this.DropMasterButtonClick);
			// 
			// SettingsFirmiDataGridView
			// 
			this.SettingsFirmiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SettingsFirmiDataGridView.Location = new System.Drawing.Point(212, 92);
			this.SettingsFirmiDataGridView.Name = "SettingsFirmiDataGridView";
			this.SettingsFirmiDataGridView.Size = new System.Drawing.Size(194, 252);
			this.SettingsFirmiDataGridView.TabIndex = 4;
			// 
			// DropFirmaButton
			// 
			this.DropFirmaButton.Location = new System.Drawing.Point(311, 36);
			this.DropFirmaButton.Name = "DropFirmaButton";
			this.DropFirmaButton.Size = new System.Drawing.Size(96, 23);
			this.DropFirmaButton.TabIndex = 7;
			this.DropFirmaButton.Text = "Удалить";
			this.DropFirmaButton.UseVisualStyleBackColor = true;
			this.DropFirmaButton.Click += new System.EventHandler(this.DropFirmaButtonClick);
			// 
			// AddFirmaButton
			// 
			this.AddFirmaButton.Location = new System.Drawing.Point(213, 36);
			this.AddFirmaButton.Name = "AddFirmaButton";
			this.AddFirmaButton.Size = new System.Drawing.Size(92, 23);
			this.AddFirmaButton.TabIndex = 6;
			this.AddFirmaButton.Text = "Добавить ";
			this.AddFirmaButton.UseVisualStyleBackColor = true;
			this.AddFirmaButton.Click += new System.EventHandler(this.AddFirmaButtonClick);
			// 
			// SettingsFirmaTextBox
			// 
			this.SettingsFirmaTextBox.Location = new System.Drawing.Point(213, 65);
			this.SettingsFirmaTextBox.Name = "SettingsFirmaTextBox";
			this.SettingsFirmaTextBox.Size = new System.Drawing.Size(194, 20);
			this.SettingsFirmaTextBox.TabIndex = 5;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 356);
			this.Controls.Add(this.DropFirmaButton);
			this.Controls.Add(this.AddFirmaButton);
			this.Controls.Add(this.SettingsFirmaTextBox);
			this.Controls.Add(this.SettingsFirmiDataGridView);
			this.Controls.Add(this.DropMasterButton);
			this.Controls.Add(this.AddMasterButton);
			this.Controls.Add(this.SettingsMasterTextBox);
			this.Controls.Add(this.SettingsMastersDataGridView);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.SettingsMastersDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SettingsFirmiDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox SettingsFirmaTextBox;
		private System.Windows.Forms.Button AddFirmaButton;
		private System.Windows.Forms.Button DropFirmaButton;
		private System.Windows.Forms.DataGridView SettingsFirmiDataGridView;
		private System.Windows.Forms.Button DropMasterButton;
		private System.Windows.Forms.Button AddMasterButton;
		private System.Windows.Forms.TextBox SettingsMasterTextBox;
		private System.Windows.Forms.DataGridView SettingsMastersDataGridView;
	}
}
