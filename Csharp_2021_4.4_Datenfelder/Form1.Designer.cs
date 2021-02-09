
namespace Csharp_2021_4._4_Datenfelder
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstFeld = new System.Windows.Forms.ListBox();
			this.btnAnzeigen1 = new System.Windows.Forms.Button();
			this.btnAnzeigen2 = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.btnAnzeigen3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstFeld
			// 
			this.lstFeld.FormattingEnabled = true;
			this.lstFeld.Location = new System.Drawing.Point(12, 12);
			this.lstFeld.Name = "lstFeld";
			this.lstFeld.Size = new System.Drawing.Size(120, 199);
			this.lstFeld.TabIndex = 0;
			// 
			// btnAnzeigen1
			// 
			this.btnAnzeigen1.Location = new System.Drawing.Point(309, 13);
			this.btnAnzeigen1.Name = "btnAnzeigen1";
			this.btnAnzeigen1.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeigen1.TabIndex = 1;
			this.btnAnzeigen1.Text = "Anzeigen 1";
			this.btnAnzeigen1.UseVisualStyleBackColor = true;
			this.btnAnzeigen1.Click += new System.EventHandler(this.btnAnzeigen1_Click);
			// 
			// btnAnzeigen2
			// 
			this.btnAnzeigen2.Location = new System.Drawing.Point(309, 43);
			this.btnAnzeigen2.Name = "btnAnzeigen2";
			this.btnAnzeigen2.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeigen2.TabIndex = 2;
			this.btnAnzeigen2.Text = "Anzeigen 2";
			this.btnAnzeigen2.UseVisualStyleBackColor = true;
			this.btnAnzeigen2.Click += new System.EventHandler(this.btnAnzeigen2_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(153, 182);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 3;
			this.lblAusgabe.Text = "label1";
			// 
			// btnAnzeigen3
			// 
			this.btnAnzeigen3.Location = new System.Drawing.Point(309, 73);
			this.btnAnzeigen3.Name = "btnAnzeigen3";
			this.btnAnzeigen3.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeigen3.TabIndex = 4;
			this.btnAnzeigen3.Text = "Anzeigen 3";
			this.btnAnzeigen3.UseVisualStyleBackColor = true;
			this.btnAnzeigen3.Click += new System.EventHandler(this.btnAnzeigen3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 225);
			this.Controls.Add(this.btnAnzeigen3);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnAnzeigen2);
			this.Controls.Add(this.btnAnzeigen1);
			this.Controls.Add(this.lstFeld);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstFeld;
		private System.Windows.Forms.Button btnAnzeigen1;
		private System.Windows.Forms.Button btnAnzeigen2;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.Button btnAnzeigen3;
	}
}

