/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 11.12.2016
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Zverev_Kursova_OBD
{
	partial class AddTableForm
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
			this.NewTableTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddTableButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NewTableTextBox
			// 
			this.NewTableTextBox.Location = new System.Drawing.Point(12, 46);
			this.NewTableTextBox.Name = "NewTableTextBox";
			this.NewTableTextBox.Size = new System.Drawing.Size(268, 20);
			this.NewTableTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Введіть назву нової таблиці";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddTableButton
			// 
			this.AddTableButton.Location = new System.Drawing.Point(12, 72);
			this.AddTableButton.Name = "AddTableButton";
			this.AddTableButton.Size = new System.Drawing.Size(268, 23);
			this.AddTableButton.TabIndex = 2;
			this.AddTableButton.Text = "Створити нову таблицю";
			this.AddTableButton.UseVisualStyleBackColor = true;
			this.AddTableButton.Click += new System.EventHandler(this.AddTableButtonClick);
			// 
			// AddTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 109);
			this.Controls.Add(this.AddTableButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NewTableTextBox);
			this.Name = "AddTableForm";
			this.Text = "AddTableForm";
			this.Load += new System.EventHandler(this.AddTableFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button AddTableButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NewTableTextBox;
	}
}
